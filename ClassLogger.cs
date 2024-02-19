using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP
{
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
                "濃度(ppm)",
                "温度(℃)",
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
            if (DataBuffer.Count > 10)
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

            foreach (var buff in DataBuffer)
            {
                ///Hardware
                string hardware = buff.MsgFD.DEVICE.ToString();

                ///CANID
                string id = buff.MsgFD.ID.ToString("x3");

                ///送信カウンタ
                counter = (int)(buff.MsgFD.DATA[0]);

                ///濃度
                sensor = (int)(buff.MsgFD.DATA[2]) - (int)(buff.MsgFD.DATA[3]);

                ///温度
                temperature = (buff.MsgFD.DATA[5] > 128) ? buff.MsgFD.DATA[5] - 256 : buff.MsgFD.DATA[5];

                ///書込みデータ生成
                str +=
                hardware + "," +
                id + "," +
                buff.TimeStamp + "," +
                counter + "," +
                sensor + "," +
                temperature + "\n";
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
