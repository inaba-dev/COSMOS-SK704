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

namespace APP
{
    public partial class UserControlUnits : UserControl
    {
        private ClassLoggers ClassLogger = new ClassLoggers();

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
        /// 
        /// </summary>

        private bool[] GetValids()
        {
            bool[] _valid = new bool[6];
            _valid[0] = userControlUnit1.checkValid.Checked;
            _valid[1] = userControlUnit2.checkValid.Checked;
            _valid[2] = userControlUnit3.checkValid.Checked;
            _valid[3] = userControlUnit4.checkValid.Checked;
            _valid[4] = userControlUnit5.checkValid.Checked;
            _valid[5] = userControlUnit6.checkValid.Checked;
            return _valid;
        }

        private bool[] GetModes()
        {
            bool[] _mode = new bool[6];
            _mode[0] = userControlUnit1.radioLeakage.Checked;
            _mode[1] = userControlUnit2.radioLeakage.Checked;
            _mode[2] = userControlUnit3.radioLeakage.Checked;
            _mode[3] = userControlUnit4.radioLeakage.Checked;
            _mode[4] = userControlUnit5.radioLeakage.Checked;
            _mode[5] = userControlUnit6.radioLeakage.Checked;
            return _mode;
        }

        /// <summary>
        /// 
        /// </summary>

        public UserControlUnits()
        {
            InitializeComponent();

            Initialization();

            chartSensor.ChartAreas[0].AxisY.Maximum = 20;
            chartSensor.ChartAreas[0].AxisY.Minimum = -5;
        }

        /// <summary>
        /// シャットダウン
        /// </summary>

        public void Shutdouw()
        {
            if (bLogging)
            {
                ///ロギング停止
                ClassLogger.Close();

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
                uint id1 = Convert.ToUInt32(userControlUnit1.txtID.Text, 16);
                uint id2 = Convert.ToUInt32(userControlUnit2.txtID.Text, 16);
                uint id3 = Convert.ToUInt32(userControlUnit3.txtID.Text, 16);
                uint id4 = Convert.ToUInt32(userControlUnit4.txtID.Text, 16);
                uint id5 = Convert.ToUInt32(userControlUnit5.txtID.Text, 16);
                uint id6 = Convert.ToUInt32(userControlUnit6.txtID.Text, 16);

                if (Msg.ID == id1 && userControlUnit1.HWInfo() == Msg.DEVICE)
                {
                    ///Status
                    userControlUnit1.Display(Msg.DATA);

                    ///ログ記録
                    if (bLogging) ClassLogger.ClassLogger[0].Write(Msg);
                }
                if (Msg.ID == id2 && userControlUnit2.HWInfo() == Msg.DEVICE)
                {
                    ///Status
                    userControlUnit2.Display(Msg.DATA);

                    ///ログ記録
                    if (bLogging) ClassLogger.ClassLogger[1].Write(Msg);
                }
                if (Msg.ID == id3 && userControlUnit3.HWInfo() == Msg.DEVICE)
                {
                    ///Status
                    userControlUnit3.Display(Msg.DATA);

                    ///ログ記録
                    if (bLogging) ClassLogger.ClassLogger[2].Write(Msg);
                }
                if (Msg.ID == id4 && userControlUnit4.HWInfo() == Msg.DEVICE)
                {
                    ///Status
                    userControlUnit4.Display(Msg.DATA);

                    ///ログ記録
                    if (bLogging) ClassLogger.ClassLogger[3].Write(Msg);
                }
                if (Msg.ID == id5 && userControlUnit5.HWInfo() == Msg.DEVICE)
                {
                    ///Status
                    userControlUnit5.Display(Msg.DATA);

                    ///ログ記録
                    if (bLogging) ClassLogger.ClassLogger[4].Write(Msg);
                }
                if (Msg.ID == id6 && userControlUnit6.HWInfo() == Msg.DEVICE)
                {
                    ///Status
                    userControlUnit6.Display(Msg.DATA);

                    ///ログ記録
                    if (bLogging) ClassLogger.ClassLogger[5].Write(Msg);
                }
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
                ClassLogger.Close();

                bLogging = false;
            }
            else
            {
                ///有効/無効を取得
                ClassLogger.setValid(GetValids());

                ///対象種類を取得
                ClassLogger.setMode(GetModes());

                ///開始時間の記録
                ClassLogger.setStartTime();

                ///ロギング開始
                if (!ClassLogger.Init(textBoxPath.Text)) return;

                bLogging = true;
            }

            ///表示更新
            //SetConnectionStatus();
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
                span = ClassLogger.getRunTime();
                labelRunTime.Text = span.ToString(@"hh\:mm\:ss");

            }
            ///ロギング停止中
            else
            {
                labelRunTime.Visible = false;
            }

            ///グラフプロット
            bool bConnected = ClassPeripheral.CAN1.IsConnect();
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
