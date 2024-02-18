using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

using TPCANHandle = System.UInt16;
using TPCANBitrateFD = System.String;
using TPCANTimestampFD = System.UInt64;

namespace APP
{
    public partial class FormMain : Form
    {
        // キャンセルトークンソースを生成
        CancellationTokenSource tokenSource;

        public FormMain()
        {
            InitializeComponent();

            ///
            execLoadConfig();

            ///
            SetConnectionStatus();

            ///
            getSoftwareVersion();

            ///CAN-IDのリストを初期化
            mCanIdList = new List<string>();
        }

        /// <summary>
        /// 
        /// </summary>

        public delegate void FuncDelegate(TPCANMsgFD Msg);

        private void RecvEvent(object sender, TPCANMsgFD Msg)
        {
            ///ListView表示
            Invoke(new FuncDelegate(InsertMsgEntry), Msg);

            ///ステータス更新
            Invoke(new FuncDelegate(userControlLogger.StatusModify), Msg);
        }

        /// <summary>
        /// ソフトウェアバージョンの読込
        /// </summary>

        private void getSoftwareVersion()
        {
            System.Diagnostics.FileVersionInfo ver =
            System.Diagnostics.FileVersionInfo.GetVersionInfo(
            System.Reflection.Assembly.GetExecutingAssembly().Location);

            this.Text = String.Format("{0} Ver {1}.{2}.{3}", ver.ProductName, ver.FileMajorPart.ToString(), ver.FileMinorPart, ver.FileBuildPart);
        }

        /// <summary>
        /// 
        /// </summary>

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //メッセージボックスを表示する
            DialogResult result = MessageBox.Show("アプリケーションを終了しますか？", "終了の確認",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2);

            //何が選択されたか調べる
            if (result == DialogResult.Yes)
            {
                //「はい」が選択された時
                Console.WriteLine("「はい」が選択されました");
            }
            else if (result == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            ///フォーム保存
            execSaveConfig();

            ///切断
            buttonDisConnect_Click(null, null);

            e.Cancel = false;
        }

        /// <summary>
        /// 
        /// </summary>

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            ///フォーム保存
            execSaveConfig();

            ///接続
            if (cbbChannel1.SelectedIndex >= 0)
            {
                if (!ClassPeripheral.CAN1.Connect(0x600, cbbChannel1.SelectedIndex, false))
                {
                    MessageBox.Show("機器1の接続に失敗しました。", "接続エラー");
                    //return;
                }
            }

            if (cbbChannel2.SelectedIndex >= 0)
            {
                if (!ClassPeripheral.CAN2.Connect(0x600, cbbChannel2.SelectedIndex, false))
                {
                    MessageBox.Show("機器2の接続に失敗しました。", "接続エラー");
                    //return;
                }
            }

            if (cbbChannel3.SelectedIndex >= 0)
            {
                if (!ClassPeripheral.CAN3.Connect(0x600, cbbChannel3.SelectedIndex, false))
                {
                    MessageBox.Show("機器3の接続に失敗しました。", "接続エラー");
                    //return;
                }
            }

            if (cbbChannel4.SelectedIndex >= 0)
            {
                if (!ClassPeripheral.CAN4.Connect(0x600, cbbChannel4.SelectedIndex, false))
                {
                    MessageBox.Show("機器4の接続に失敗しました。", "接続エラー");
                    //return;
                }
            }

            if (cbbChannel5.SelectedIndex >= 0)
            {
                if (!ClassPeripheral.CAN5.Connect(0x600, cbbChannel5.SelectedIndex, false))
                {
                    MessageBox.Show("機器5の接続に失敗しました。", "接続エラー");
                    //return;
                }
            }

            if (cbbChannel6.SelectedIndex >= 0)
            {
                if (!ClassPeripheral.CAN6.Connect(0x600, cbbChannel6.SelectedIndex, false))
                {
                    MessageBox.Show("機器6の接続に失敗しました。", "接続エラー");
                    //return;
                }
            }

            ///受信スレッド開始
            ReadThread();

            ///
            userControlLogger.tmrRead.Enabled = true;

            ///表示更新
            SetConnectionStatus();
        }

        private void buttonDisConnect_Click(object sender, EventArgs e)
        {
            ///Taskキャンセル
            if(tokenSource != null) tokenSource.Cancel();

            ///
            userControlLogger.tmrRead.Enabled = false;

            ///表示停止
            userControlLogger.Shutdouw();

            ///CAN切断
            if (ClassPeripheral.CAN1 != null) ClassPeripheral.CAN1.DisConnect();
            if (ClassPeripheral.CAN2 != null) ClassPeripheral.CAN2.DisConnect();
            if (ClassPeripheral.CAN3 != null) ClassPeripheral.CAN3.DisConnect();
            if (ClassPeripheral.CAN4 != null) ClassPeripheral.CAN4.DisConnect();
            if (ClassPeripheral.CAN5 != null) ClassPeripheral.CAN5.DisConnect();
            if (ClassPeripheral.CAN6 != null) ClassPeripheral.CAN6.DisConnect();

            ///表示更新
            SetConnectionStatus();
        }

        /// <summary>
        /// 
        /// </summary>

        public delegate void ReadDelegate();

        public int i = 0;

        public async void ReadThread()
        {
            tokenSource = new CancellationTokenSource();

#if !TESTMODE
            await Task.Run(() =>
            {
                while (true)
                {
                    /// トークンキャンセルされていればBreak
                    if (tokenSource.IsCancellationRequested) break;

                    /// 受信処理
                    Invoke(new ReadDelegate(ClassPeripheral.CAN1.ReadMessages));
                    Invoke(new ReadDelegate(ClassPeripheral.CAN2.ReadMessages));
                    Invoke(new ReadDelegate(ClassPeripheral.CAN3.ReadMessages));
                    Invoke(new ReadDelegate(ClassPeripheral.CAN4.ReadMessages));
                    Invoke(new ReadDelegate(ClassPeripheral.CAN5.ReadMessages));
                    Invoke(new ReadDelegate(ClassPeripheral.CAN6.ReadMessages));

                    Thread.Sleep(10);
                }
            });
#else
            TPCANMsgFD Msg = new TPCANMsgFD();

            Msg.DATA = new Byte[8];

            Random r1 = new System.Random();

            await Task.Run(() =>
            {
                while (true)
                {
                    Msg.ID = 0x0600;
                    Msg.DLC = 8;
                    Msg.DATA[0] = 0x00;
                    Msg.DATA[1] = (byte)i;
                    Msg.DATA[2] = (byte)r1.Next(0, 100);
                    Msg.DATA[3] = 0x00;
                    Msg.DATA[4] = 0x00;
                    Msg.DATA[5] = (byte)r1.Next(0, 100);
                    Msg.DATA[6] = (byte)2;
                    Msg.DATA[7] = (byte)0x23;
                    Msg.MSGTYPE = TPCANMessageType.PCAN_MESSAGE_STANDARD;
                    Msg.DEVICE = "6&ec8b2d8&0&0000";

                    i++;

                    /// トークンキャンセルされていればBreak
                    if (tokenSource.IsCancellationRequested) break;

                    ///ListView表示
                    Invoke(new FuncDelegate(InsertMsgEntry), Msg);

                    ///ステータス更新
                    Invoke(new FuncDelegate(userControlLogger.StatusModify), Msg);

                    Thread.Sleep(200);
                }
            });
#endif
        }

        /// <summary>
        /// 
        /// </summary>

        private void btnMsgClear_Click(object sender, EventArgs e)
        {
            lstMessages.Items.Clear();
        }

        /// <summary>
        /// 
        /// </summary>

        private void cbbBaudrates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ClassPeripheral.CAN1 != null)
            {
                ClassPeripheral.CAN1.cbbBaudrates_SelectedIndexChanged(cbbBaudrates.SelectedIndex);
            }

            if (ClassPeripheral.CAN2 != null)
            {
                ClassPeripheral.CAN2.cbbBaudrates_SelectedIndexChanged(cbbBaudrates.SelectedIndex);
            }

            if (ClassPeripheral.CAN3 != null)
            {
                ClassPeripheral.CAN3.cbbBaudrates_SelectedIndexChanged(cbbBaudrates.SelectedIndex);
            }

            if (ClassPeripheral.CAN4 != null)
            {
                ClassPeripheral.CAN4.cbbBaudrates_SelectedIndexChanged(cbbBaudrates.SelectedIndex);
            }

            if (ClassPeripheral.CAN5 != null)
            {
                ClassPeripheral.CAN5.cbbBaudrates_SelectedIndexChanged(cbbBaudrates.SelectedIndex);
            }

            if (ClassPeripheral.CAN6 != null)
            {
                ClassPeripheral.CAN6.cbbBaudrates_SelectedIndexChanged(cbbBaudrates.SelectedIndex);
            }
        }

        /// <summary>
        /// 
        /// </summary>

        private void comboGraph_SelectedValueChanged(object sender, EventArgs e)
        {
            userControlLogger.Initialization();
        }

        /// <summary>
        /// 
        /// </summary>

        private void buttonScan_Click(object sender, EventArgs e)
        {
            btnHwRefresh();
        }

        /// <summary>
        /// 
        /// </summary>

        private void radioModePeak_CheckedChanged(object sender, EventArgs e)
        {
            ClassPeripheral.CAN1 = new ClassPeakCanController();
            ClassPeripheral.CAN2 = new ClassPeakCanController();
            ClassPeripheral.CAN3 = new ClassPeakCanController();
            ClassPeripheral.CAN4 = new ClassPeakCanController();
            ClassPeripheral.CAN5 = new ClassPeakCanController();
            ClassPeripheral.CAN6 = new ClassPeakCanController();

            ///CANセットアップ
            reloadCanSetup();
        }

        private void radioModeInno_CheckedChanged(object sender, EventArgs e)
        {
            ClassPeripheral.CAN1 = new ClassInnoCanController();
            ClassPeripheral.CAN2 = new ClassInnoCanController();
            ClassPeripheral.CAN3 = new ClassInnoCanController();
            ClassPeripheral.CAN4 = new ClassInnoCanController();
            ClassPeripheral.CAN5 = new ClassInnoCanController();
            ClassPeripheral.CAN6 = new ClassInnoCanController();

            ///CANセットアップ
            reloadCanSetup();
        }

        private void reloadCanSetup()
        {
            ///CAN初期化
            ClassPeripheral.CAN1.Init();
            ClassPeripheral.CAN2.Init();
            ClassPeripheral.CAN3.Init();
            ClassPeripheral.CAN4.Init();
            ClassPeripheral.CAN5.Init();
            ClassPeripheral.CAN6.Init();

            ///ボーレート設定
            cbbBaudrates_SelectedIndexChanged(null, null);

            ///ハードウェア設定
            btnHwRefresh();

            ///イベント登録
            ClassPeripheral.CAN1.m_ReceiveEvent += RecvEvent;
            ClassPeripheral.CAN2.m_ReceiveEvent += RecvEvent;
            ClassPeripheral.CAN3.m_ReceiveEvent += RecvEvent;
            ClassPeripheral.CAN4.m_ReceiveEvent += RecvEvent;
            ClassPeripheral.CAN5.m_ReceiveEvent += RecvEvent;
            ClassPeripheral.CAN6.m_ReceiveEvent += RecvEvent;
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chCheck;

            // We convert the Character to its Upper case equivalent
            chCheck = char.ToUpper(e.KeyChar);

            // The Key is the Delete (Backspace) Key
            if (chCheck == 8)
                return;

            // The Key is a number between 0-9
            if ((chCheck > 47) && (chCheck < 58))
                return;

            // The Key is a character between A-F
            if ((chCheck > 64) && (chCheck < 71))
                return;

            // Is neither a number nor a character between A(a) and F(f)
            e.Handled = true;
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            userControlLogger.buttonLog_Click();

            ///表示更新
            SetConnectionStatus();
        }
    }
}
