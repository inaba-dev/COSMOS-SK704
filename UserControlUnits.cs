using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;

namespace APP
{
    public partial class UserControlUnits : UserControl
    {
        private bool bLogging { get; set; }

        public bool IsLogging() { return bLogging; }

        //データ数
        private const int DEF_CHART_POINT = 100;

        private List<DataClass> DataArray = new List<DataClass>();

        private class DataClass
        {
            public double[] sensor = new double[6];
            public double[] temperature = new double[6];
        }

        /// <summary>
        /// 
        /// </summary>

        public UserControlUnits()
        {
            InitializeComponent();

            Initialization();

            userControlStatus1.Initialize(0);
            userControlStatus2.Initialize(1);
            userControlStatus3.Initialize(2);
            userControlStatus4.Initialize(3);
            userControlStatus5.Initialize(4);
            userControlStatus6.Initialize(5);

            userControlRegister1.Initialize(0);
            userControlRegister2.Initialize(1);
            userControlRegister3.Initialize(2);
            userControlRegister4.Initialize(3);
            userControlRegister5.Initialize(4);
            userControlRegister6.Initialize(5);

            userControlMonitor.Setup();
        }

        /// <summary>
        /// 
        /// </summary>

        public void SetEnables(bool bConnected)
        {
            userControlStatus1.SetEnable(bConnected, bLogging);
            userControlStatus2.SetEnable(bConnected, bLogging);
            userControlStatus3.SetEnable(bConnected, bLogging);
            userControlStatus4.SetEnable(bConnected, bLogging);
            userControlStatus5.SetEnable(bConnected, bLogging);
            userControlStatus6.SetEnable(bConnected, bLogging);
        }

        /// <summary>
        /// 
        /// </summary>

        public void Setup(List<string> devices)
        {
            userControlStatus1.HWInit(devices);
            userControlStatus2.HWInit(devices);
            userControlStatus3.HWInit(devices);
            userControlStatus4.HWInit(devices);
            userControlStatus5.HWInit(devices);
            userControlStatus6.HWInit(devices);
        }

        /// <summary>
        /// 接続/切断
        /// </summary>

        public void Connect()
        {
            ///タイマ開始
            tmrRead.Enabled = true;

            ///H/W情報を記録
            Properties.Settings.Default.Hard1 = userControlStatus1.HWInfo();
            Properties.Settings.Default.Hard2 = userControlStatus2.HWInfo();
            Properties.Settings.Default.Hard3 = userControlStatus3.HWInfo();
            Properties.Settings.Default.Hard4 = userControlStatus4.HWInfo();
            Properties.Settings.Default.Hard5 = userControlStatus5.HWInfo();
            Properties.Settings.Default.Hard6 = userControlStatus6.HWInfo();

            ///H/W情報セット
            userControlRegister1.HWSetup(Properties.Settings.Default.Hard1);
            userControlRegister2.HWSetup(Properties.Settings.Default.Hard2);
            userControlRegister3.HWSetup(Properties.Settings.Default.Hard3);
            userControlRegister4.HWSetup(Properties.Settings.Default.Hard4);
            userControlRegister5.HWSetup(Properties.Settings.Default.Hard5);
            userControlRegister6.HWSetup(Properties.Settings.Default.Hard6);
        }

        public void DisConnect()
        {
            if (bLogging)
            {
                ///ロギング停止
                LoggingEnd();

                bLogging = false;
            }
        }

        /// <summary>
        /// 初期値
        /// </summary>

        public void Initialization()
        {
            DataArray.Clear();

            DataClass data = new DataClass();

            data.sensor = (Enumerable.Range(0, 6).Select(x => 0.0).ToArray());
            data.temperature = (Enumerable.Range(0, 6).Select(x => 0.0).ToArray());

            for (int i = 0; i < DEF_CHART_POINT; i++)
            {
                DataArray.Add(data);
            }
        }

        /// <summary>
        /// データプロット
        /// </summary>

        public void StatusModify(TPCANMsgFD Msg)
        {
            try
            {
                userControlStatus1.Display(Msg);
                userControlStatus2.Display(Msg);
                userControlStatus3.Display(Msg);
                userControlStatus4.Display(Msg);
                userControlStatus5.Display(Msg);
                userControlStatus6.Display(Msg);

                userControlRegister1.Display(Msg);
                userControlRegister2.Display(Msg);
                userControlRegister3.Display(Msg);
                userControlRegister4.Display(Msg);
                userControlRegister5.Display(Msg);
                userControlRegister6.Display(Msg);

                userControlMonitor.RecvEvent(Msg);
            }
            catch
            {

            }
        }

        public void GraphPlot()
        {
            {
                while (true)
                {
                    //サイズが規定数まで達してなければBreak
                    if (DataArray.Count < DEF_CHART_POINT) break;

                    //先頭のデータを削除
                    DataArray.RemoveAt(0);
                }

                DataClass _data = new DataClass();

                ///データを最後尾に追加

                _data.sensor[0] = userControlStatus1.CurrentSensor;
                _data.sensor[1] = userControlStatus2.CurrentSensor;
                _data.sensor[2] = userControlStatus3.CurrentSensor;
                _data.sensor[3] = userControlStatus4.CurrentSensor;
                _data.sensor[4] = userControlStatus5.CurrentSensor;
                _data.sensor[5] = userControlStatus6.CurrentSensor;

                _data.temperature[0] = userControlStatus1.CurrentTemperature;
                _data.temperature[1] = userControlStatus2.CurrentTemperature;
                _data.temperature[2] = userControlStatus3.CurrentTemperature;
                _data.temperature[3] = userControlStatus4.CurrentTemperature;
                _data.temperature[4] = userControlStatus5.CurrentTemperature;
                _data.temperature[5] = userControlStatus6.CurrentTemperature;

                DataArray.Add(_data);

                ///グラフクリア

                for (int i = 0; i < _data.sensor.Count(); i++)
                {
                    chartSensor.Series[i].Points.Clear();
                    chartTemperature.Series[i].Points.Clear();
                }

                ///グラフ描画

                for (int i = 0; i < _data.sensor.Count(); i++)
                {
                    for (int index = 0; index < DataArray.Count(); index++)
                    {
                        chartSensor.Series[i].Points.Add(DataArray[index].sensor[i]);
                        chartTemperature.Series[i].Points.Add(DataArray[index].temperature[i]);
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>

        public void buttonLog_Click()
        {
            if (bLogging)
            {
                ///ロギング停止
                LoggingEnd();

                bLogging = false;
            }
            else
            {
                ///開始時間の記録
                setStartTime();

                ///ロギング開始
                LoggingStart(textBoxPath.Text);

                bLogging = true;
            }

            ///表示更新
            //SetConnectionStatus();
        }

        /// <summary>
        /// 
        /// </summary>

        private DateTime StartTime = DateTime.Now;

        public TimeSpan getRunTime()
        {
            DateTime dt = DateTime.Now;
            TimeSpan span = dt - StartTime;
            return span;
        }

        public void setStartTime()
        {
            StartTime = DateTime.Now;
        }

        /// <summary>
        /// 
        /// </summary>

        public void LoggingStart(string path)
        {
            ///フォルダの存在確認
            if (!Directory.Exists(path))
            {
                MessageBox.Show("フォルダが存在しません", "フォルダエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            userControlStatus1.LogStart(path);
            userControlStatus2.LogStart(path);
            userControlStatus3.LogStart(path);
            userControlStatus4.LogStart(path);
            userControlStatus5.LogStart(path);
            userControlStatus6.LogStart(path);
        }

        public void LoggingEnd()
        {
            userControlStatus1.LogEnd();
            userControlStatus2.LogEnd();
            userControlStatus3.LogEnd();
            userControlStatus4.LogEnd();
            userControlStatus5.LogEnd();
            userControlStatus6.LogEnd();
        }

        /// <summary>
        /// 
        /// </summary>

        private void tmrRead_Tick(object sender, EventArgs e)
        {
            ///ロギング実行中
            if (bLogging)
            {
                labelRunTime.Visible = true;

                TimeSpan span;
                span = getRunTime();
                labelRunTime.Text = span.ToString(@"hh\:mm\:ss");

            }
            ///ロギング停止中
            else
            {
                labelRunTime.Visible = false;
            }

            ///グラフプロット
            bool bConnected = ClassPeripheral.CAN[0].IsConnect();
            if (bConnected)
            {
                GraphPlot();
            }
        }

        /// <summary>
        /// 
        /// </summary>

        private void buttonPath_Click(object sender, EventArgs e)
        {
            /// FolderBrowserDialogクラスのインスタンスを作成
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            /// 上部に表示する説明テキストを指定する
            fbd.Description = "フォルダを指定してください。";

            /// ルートフォルダを指定する(デフォルトでDesktop)
            fbd.RootFolder = Environment.SpecialFolder.Desktop;

            /// 最初に選択するフォルダを指定する
            if (System.IO.Directory.Exists(textBoxPath.Text))
            {
                fbd.SelectedPath = textBoxPath.Text;
            }
            else
            {
                fbd.SelectedPath = @"C:\Windows";
            }

            /// ユーザーが新しいフォルダを作成できるようにする
            fbd.ShowNewFolderButton = true;

            /// ダイアログを表示する
            if (fbd.ShowDialog(this) == DialogResult.OK)
            {
                /// 選択されたフォルダを表示する
                textBoxPath.Text = fbd.SelectedPath;
            }
        }
    }
}
