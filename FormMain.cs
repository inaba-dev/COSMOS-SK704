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
            ClassPeripheral.CAN[0] = new ClassInnoCanController();
            ClassPeripheral.CAN[1] = new ClassInnoCanController();
            ClassPeripheral.CAN[2] = new ClassInnoCanController();
            ClassPeripheral.CAN[3] = new ClassInnoCanController();
            ClassPeripheral.CAN[4] = new ClassInnoCanController();
            ClassPeripheral.CAN[5] = new ClassInnoCanController();

            InitializeComponent();

            ///CAN初期化
            for (int i = 0; i < ClassPeripheral.CAN.Count(); i++)
            {
                ClassPeripheral.CAN[i].Init();
            }

            ///CANイベント登録
            ClassPeripheral.CAN[0].m_ReceiveEvent += RecvEvent;
            ClassPeripheral.CAN[1].m_ReceiveEvent += RecvEvent;
            ClassPeripheral.CAN[2].m_ReceiveEvent += RecvEvent;
            ClassPeripheral.CAN[3].m_ReceiveEvent += RecvEvent;
            ClassPeripheral.CAN[4].m_ReceiveEvent += RecvEvent;
            ClassPeripheral.CAN[5].m_ReceiveEvent += RecvEvent;

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
            Invoke(new FuncDelegate(userControlUnits.StatusModify), Msg);
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

            bool bExtend = false;// (radioTypeB.Checked);
            uint CmdId = bExtend ? Define.CMD_PACKET_TYPE_EXT_ID : Define.CMD_PACKET_TYPE_STD_ID;

            ///接続
            if (checkCh1.Checked && cbbChannel1.SelectedIndex >= 0)
            {
                if (!ClassPeripheral.CAN[0].Connect(CmdId, cbbChannel1.SelectedIndex, bExtend))
                {
                    MessageBox.Show("機器1の接続に失敗しました。", "接続エラー");
                    //return;
                }
            }

            if (checkCh2.Checked && cbbChannel2.SelectedIndex >= 0)
            {
                if (!ClassPeripheral.CAN[1].Connect(CmdId, cbbChannel2.SelectedIndex, bExtend))
                {
                    MessageBox.Show("機器2の接続に失敗しました。", "接続エラー");
                    //return;
                }
            }

            if (checkCh3.Checked && cbbChannel3.SelectedIndex >= 0)
            {
                if (!ClassPeripheral.CAN[2].Connect(CmdId, cbbChannel3.SelectedIndex, bExtend))
                {
                    MessageBox.Show("機器3の接続に失敗しました。", "接続エラー");
                    //return;
                }
            }

            if (checkCh4.Checked && cbbChannel4.SelectedIndex >= 0)
            {
                if (!ClassPeripheral.CAN[3].Connect(CmdId, cbbChannel4.SelectedIndex, bExtend))
                {
                    MessageBox.Show("機器4の接続に失敗しました。", "接続エラー");
                    //return;
                }
            }

            if (checkCh5.Checked && cbbChannel5.SelectedIndex >= 0)
            {
                if (!ClassPeripheral.CAN[4].Connect(CmdId, cbbChannel5.SelectedIndex, bExtend))
                {
                    MessageBox.Show("機器5の接続に失敗しました。", "接続エラー");
                    //return;
                }
            }

            if (checkCh6.Checked && cbbChannel6.SelectedIndex >= 0)
            {
                if (!ClassPeripheral.CAN[5].Connect(CmdId, cbbChannel6.SelectedIndex, bExtend))
                {
                    MessageBox.Show("機器6の接続に失敗しました。", "接続エラー");
                    //return;
                }
            }
            
            ///受信スレッド開始
            ReadThread();

            ///
            userControlUnits.Connect();

            ///表示更新
            SetConnectionStatus();
        }

        private void buttonDisConnect_Click(object sender, EventArgs e)
        {
            ///Taskキャンセル
            if(tokenSource != null) tokenSource.Cancel();

            ///表示停止
            userControlUnits.DisConnect();

            ///CAN切断
            if (ClassPeripheral.CAN[0] != null) ClassPeripheral.CAN[0].DisConnect();
            if (ClassPeripheral.CAN[1] != null) ClassPeripheral.CAN[1].DisConnect();
            if (ClassPeripheral.CAN[2] != null) ClassPeripheral.CAN[2].DisConnect();
            if (ClassPeripheral.CAN[3] != null) ClassPeripheral.CAN[3].DisConnect();
            if (ClassPeripheral.CAN[4] != null) ClassPeripheral.CAN[4].DisConnect();
            if (ClassPeripheral.CAN[5] != null) ClassPeripheral.CAN[5].DisConnect();

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
                    if (ClassPeripheral.CAN[0].IsConnect()) Invoke(new ReadDelegate(ClassPeripheral.CAN[0].ReadMessages));
                    if (ClassPeripheral.CAN[1].IsConnect()) Invoke(new ReadDelegate(ClassPeripheral.CAN[1].ReadMessages));
                    if (ClassPeripheral.CAN[2].IsConnect()) Invoke(new ReadDelegate(ClassPeripheral.CAN[2].ReadMessages));
                    if (ClassPeripheral.CAN[3].IsConnect()) Invoke(new ReadDelegate(ClassPeripheral.CAN[3].ReadMessages));
                    if (ClassPeripheral.CAN[4].IsConnect()) Invoke(new ReadDelegate(ClassPeripheral.CAN[4].ReadMessages));
                    if (ClassPeripheral.CAN[5].IsConnect()) Invoke(new ReadDelegate(ClassPeripheral.CAN[5].ReadMessages));

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
            for(int i=0; i< ClassPeripheral.CAN.Count(); i++)
            {
                if (ClassPeripheral.CAN[i] != null)
                {
                    ClassPeripheral.CAN[i].cbbBaudrates_SelectedIndexChanged(cbbBaudrates.SelectedIndex);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>

        private void comboGraph_SelectedValueChanged(object sender, EventArgs e)
        {
            userControlUnits.Initialization();
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

        private void reloadCanSetup()
        {   
            ///ボーレートイベント
            cbbBaudrates_SelectedIndexChanged(null, null);

            ///ハードウェア設定
            btnHwRefresh();

            ///ボーレート設定
            for (int i = 0; i < ClassPeripheral.CAN.Count(); i++)
            {
                if (ClassPeripheral.CAN[i] != null)
                {
                    ClassPeripheral.CAN[i].cbbBaudrates_SelectedIndexChanged(cbbBaudrates.SelectedIndex);
                }
            }
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
            userControlUnits.buttonLog_Click();

            ///表示更新
            SetConnectionStatus();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            mCanIdList.Clear();
            lstMessages.Items.Clear();
        }
    }
}
