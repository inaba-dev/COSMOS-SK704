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

            userControlUnit1.Initialize(0);
            userControlUnit2.Initialize(1);
            userControlUnit3.Initialize(2);
            userControlUnit4.Initialize(3);
            userControlUnit5.Initialize(4);
            userControlUnit6.Initialize(5);
        }

        /// <summary>
        /// 
        /// </summary>

        public void SetEnables(bool bConnected)
        {
            userControlUnit1.SetEnable(bConnected, bLogging);
            userControlUnit2.SetEnable(bConnected, bLogging);
            userControlUnit3.SetEnable(bConnected, bLogging);
            userControlUnit4.SetEnable(bConnected, bLogging);
            userControlUnit5.SetEnable(bConnected, bLogging);
            userControlUnit6.SetEnable(bConnected, bLogging);
        }

        /// <summary>
        /// 
        /// </summary>

        public void Setup(List<string> devices)
        {
            userControlUnit1.HWSetup(devices);
            userControlUnit2.HWSetup(devices);
            userControlUnit3.HWSetup(devices);
            userControlUnit4.HWSetup(devices);
            userControlUnit5.HWSetup(devices);
            userControlUnit6.HWSetup(devices);
        }

        /// <summary>
        /// シャットダウン
        /// </summary>

        public void Connect()
        {
            ///タイマ開始
            tmrRead.Enabled = true;

            userControlUnit1.TypeSet(Properties.Settings.Default.Type);
            userControlUnit2.TypeSet(Properties.Settings.Default.Type);
            userControlUnit3.TypeSet(Properties.Settings.Default.Type);
            userControlUnit4.TypeSet(Properties.Settings.Default.Type);
            userControlUnit5.TypeSet(Properties.Settings.Default.Type);
            userControlUnit6.TypeSet(Properties.Settings.Default.Type);
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
                userControlUnit1.Display(Msg);
                userControlUnit2.Display(Msg);
                userControlUnit3.Display(Msg);
                userControlUnit4.Display(Msg);
                userControlUnit5.Display(Msg);
                userControlUnit6.Display(Msg);
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

                _data.sensor[0] = userControlUnit1.CurrentSensor;
                _data.sensor[1] = userControlUnit2.CurrentSensor;
                _data.sensor[2] = userControlUnit3.CurrentSensor;
                _data.sensor[3] = userControlUnit4.CurrentSensor;
                _data.sensor[4] = userControlUnit5.CurrentSensor;
                _data.sensor[5] = userControlUnit6.CurrentSensor;

                _data.temperature[0] = userControlUnit1.CurrentTemperature;
                _data.temperature[1] = userControlUnit2.CurrentTemperature;
                _data.temperature[2] = userControlUnit3.CurrentTemperature;
                _data.temperature[3] = userControlUnit4.CurrentTemperature;
                _data.temperature[4] = userControlUnit5.CurrentTemperature;
                _data.temperature[5] = userControlUnit6.CurrentTemperature;

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

            userControlUnit1.LogStart(path);
            userControlUnit2.LogStart(path);
            userControlUnit3.LogStart(path);
            userControlUnit4.LogStart(path);
            userControlUnit5.LogStart(path);
            userControlUnit6.LogStart(path);
        }

        public void LoggingEnd()
        {
            userControlUnit1.LogEnd();
            userControlUnit2.LogEnd();
            userControlUnit3.LogEnd();
            userControlUnit4.LogEnd();
            userControlUnit5.LogEnd();
            userControlUnit6.LogEnd();
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
