using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP
{
#if false
    public class ClassLoggers
    {
        //public ClassLogger[] ClassLogger = new ClassLogger[6];        

        /// <summary>
        /// コンストラクタ
        /// </summary>

        public ClassLoggers()
        {
            //ClassLogger[0] = new ClassLogger();
            //ClassLogger[1] = new ClassLogger();
            //ClassLogger[2] = new ClassLogger();
            //ClassLogger[3] = new ClassLogger();
            //ClassLogger[4] = new ClassLogger();
            //ClassLogger[5] = new ClassLogger();
        }

        public bool Init(string path)
        {
            ///フォルダの存在確認
            if (!Directory.Exists(path))
            {
                MessageBox.Show("フォルダが存在しません", "フォルダエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            userControlUnit1.Logger.Init(path, "1");
            ClassLogger[1].Init(path, "2");
            ClassLogger[2].Init(path, "3");
            ClassLogger[3].Init(path, "4");
            ClassLogger[4].Init(path, "5");
            ClassLogger[5].Init(path, "6");

            return true;
        }

        /*** クローズ ***/
        public void Close()
        {
            ClassLogger[0].Close();
            ClassLogger[1].Close();
            ClassLogger[2].Close();
            ClassLogger[3].Close();
            ClassLogger[4].Close();
            ClassLogger[5].Close();
        }

        /// <summary>
        /// 有効/無効
        /// </summary>

        public void setValid(bool[] valids)
        {
            ClassLogger[0].bValid = valids[0];
            ClassLogger[1].bValid = valids[1];
            ClassLogger[2].bValid = valids[2];
            ClassLogger[3].bValid = valids[3];
            ClassLogger[4].bValid = valids[4];
            ClassLogger[5].bValid = valids[5];
        }

        /// <summary>
        /// 時間管理
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
    }
#endif

    public class ClassLogger
    {
        public bool bValid { get; set; }

        public List<ClassData> DataBuffer = new List<ClassData>();

        public class ClassData
        {
            public TPCANMsgFD MsgFD;
            public string TimeStamp;
        }

        private string[] Header = new string[] {
                "HW",
                "CANID",
                "時刻",
                "カウンタ",
                "センサ(%)",
                "センサ(Raw)",
                "温度(℃)",
                "温度(Raw)",
                "湿度(%)",
                "湿度(Raw)"
            };

        private string filepath = "";
        private bool bInit = false;

        /// <summary>
        /// ロギング
        /// </summary>

        /*** 書き込みファイルパス ***/
        public bool Init(string path, string ch, bool valid)
        {
            ///有効無効
            bValid = valid;

            if (!bValid) return true;

            ///出力ファイルパス
            filepath = "";
            filepath += path + @"\";
            filepath += DateTime.Now.ToString("yyyyMMdd_HHmmss_") + ch + "ch" + ".csv";

            StreamWriter _stream = null;

            ///Open
            _stream = new StreamWriter(filepath, true, System.Text.Encoding.GetEncoding("shift_jis"));

            ///ヘッダーの書き込み
            _stream.WriteLine(String.Join(",", Header));

            ///Close
            if (_stream != null)
            {
                _stream.Flush();
                _stream.Close();
            }

            ///データバッファをクリア
            DataBuffer.Clear();

            ///初期化完了
            bInit = true;

            return true;
        }

        /*** クローズ ***/
        public void Close()
        {
            filepath = "";

            ///初期化フラグクリア
            bInit = false;
        }

        /*** データ書込み ***/
        public void Write(TPCANMsgFD data)
        {
            if (!bInit || !bValid) return;

            ClassData _data = new ClassData();

            _data.TimeStamp = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            _data.MsgFD = data;

            DataBuffer.Add(_data);

            ///ログデータ書き込み
#if !TESTMODE
            if (DataBuffer.Count > 50)
#else
            //if (DataBuffer.Count > 20)
#endif
            {
                ///書き込みデータ生成
                string str = _WriteData();

                ///ログ書き込み
                _WriteExec(str);

                ///データバッファをクリア
                DataBuffer.Clear();
            }
        }

        private string _WriteData()
        {
            string str = "";

            int counter;
            int sensor;
            int temperature;
            //string ErrorMsg;
            //string DiagInfo;

            foreach (var buff in DataBuffer)
            {
                ///Hardware
                string hardware = buff.MsgFD.DEVICE.ToString();

                ///CANID
                string id = buff.MsgFD.ID.ToString("x3");

                /*
                if (bMode)
                {
                    ///送信カウンタ
                    counter = Func.ConvSequNumber(buff.MsgFD.DATA[1] & 0x0F);

                    ///H2C
                    sensorRow = (int)((buff.MsgFD.DATA[3] & 0x0F) << 8) + (int)(buff.MsgFD.DATA[2]);
                    sensor = Func.ConvSensorLeakage(sensorRow);

                    ///気温
                    temperatureRow = (int)(buff.MsgFD.DATA[4] << 4) + (int)((buff.MsgFD.DATA[3] & 0xF0) >> 4);
                    temperature = Func.ConvTemperatureLeakage(temperatureRow);

                    ///湿度
                    humidityRow = (int)(buff.MsgFD.DATA[5]);
                    humidity = Func.ConvHumidity(humidityRow);

                    ///診断情報
                    //DiagInfo = ((buff.MsgFD.DATA[1] & 0xF0) >> 4).ToString();

                    ///書込みデータ生成
                    ///Write
                    str +=
                    hardware + "," +
                    id + "," +
                    buff.TimeStamp + "," +
                    counter + "," +
                    sensor + "," +
                    sensorRow + "," +
                    temperature + "," +
                    temperatureRow + "," +
                    humidity + "," +
                    humidityRow + "\n";
                }
                else
                {
                    ///送信カウンタ
                    counter = Func.ConvSequNumber(buff.MsgFD.DATA[1]);

                    ///H2C
                    sensorRow = (int)buff.MsgFD.DATA[2];
                    sensor = Func.ConvSensorExhaust(sensorRow);

                    ///気温
                    temperatureRow = (int)(buff.MsgFD.DATA[4] << 8) + (int)(buff.MsgFD.DATA[3]);
                    temperature = Func.ConvTemperatureExhaust(temperatureRow);

                    ///エラーフラグ
                    //ErrorMsg = (buff.MsgFD.DATA[5] & 0x07).ToString();

                    ///診断情報
                    //DiagInfo = ((buff.MsgFD.DATA[5] & 0xF8) >> 3).ToString();

                    ///書込みデータ生成
                    ///Write
                    str +=
                    hardware + "," +
                    id + "," +
                    buff.TimeStamp + "," +
                    counter + "," +
                    sensor + "," +
                    sensorRow + "," +
                    temperature + "," +
                    temperatureRow + "," +
                    "--" + "," +
                    "--" + "\n";
                }
                */
            }

            return str;
        }

        private async void _WriteExec(string str)
        {
            try
            {
                StreamWriter _stream = null;

                await Task.Run(() =>
                {
                    ///Open
                    _stream = new StreamWriter(filepath, true, System.Text.Encoding.GetEncoding("shift_jis"));

                    ///Write
                    _stream.Write(str);

                    ///Close
                    if (_stream != null)
                    {
                        _stream.Flush();
                        _stream.Close();
                    }
                });
            }
            catch
            {

            }
        }
    }
}
