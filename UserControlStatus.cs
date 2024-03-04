using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace APP
{
    public partial class UserControlStatus : UserControl
    {
        public ClassLogger Logger = new ClassLogger();

        public double CurrentSensor = 0.0;
        public double CurrentTemperature = 0.0;
        public double CurrentHumidity = 0.0;

        private uint UnitId = 0x0000;
        private uint CmdId = 0x0000;
        private int UnitNo;
        private int Type = 1;

        public UserControlStatus()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>

        public void Initialize(int unit)
        {
            UnitNo = unit;

            TypeSelect();
        }

        /// <summary>
        /// 
        /// </summary>

        public void SetEnable(bool bConnected, bool bLogging)
        {
            if (!bConnected)
            {
                this.hardware.Enabled = true;
                //this.txtID.Enabled = true;
                this.checkValid.Enabled = true;
                this.Enabled = true;
                this.BackColor = System.Drawing.SystemColors.Control;
            }
            else
            {
                if (ClassPeripheral.CAN[UnitNo].IsConnect())
                {
                    this.hardware.Enabled = false;
                    //this.txtID.Enabled = false;
                    this.checkValid.Enabled = (bLogging) ? false : true;
                    this.Enabled = true;
                    this.BackColor = (bLogging && Logger.bValid) ? Color.Beige : System.Drawing.SystemColors.Control;
                }
                else
                {
                    this.hardware.Enabled = true;
                    //this.txtID.Enabled = true;
                    this.checkValid.Enabled = true;
                    this.Enabled = false;
                    this.BackColor = Color.LightGray;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>

        public void HWInit(List<string> devices)
        {
            hardware.Items.Clear();

            foreach(var str in devices)
            {
                hardware.Items.Add(str);
            }

            ///フォーカス
            if (hardware.Items.Count > 0) hardware.SelectedIndex = 0;
        }

        public string HWInfo() { return hardware.SelectedItem.ToString(); }

        /// <summary>
        /// 
        /// </summary>

        public bool LogStart(string path)
        {
            Logger.Init(path, (UnitNo + 1).ToString(), checkValid.Checked);

            return true;
        }

        public void LogEnd()
        {
            Logger.Close();
        }

        /// <summary>
        /// 
        /// </summary>

        public void Display(TPCANMsgFD Msg)
        {
            if (!ClassPeripheral.CAN[UnitNo].IsConnect()) return;

            UnitId = Properties.Settings.Default.Extender ? Convert.ToUInt32(txtID.Text, 16) : Convert.ToUInt32(txtID.Text, 16);
            CmdId  = Properties.Settings.Default.Extender ? Define.CMD_PACKET_TYPE_EXT_ID : Define.CMD_PACKET_TYPE_STD_ID;

            if (Msg.ID == UnitId && HWInfo() == Msg.DEVICE)
            {
                int dataRaw = 0;

                if (Type == 1)
                {
                    ///送信カウンタ
                    int counter = (int)(Msg.DATA[0] & 0xF0) >> 4;
                    textBoxCounter.Text = counter.ToString();

                    ///濃度
                    int sensorRow = (int)((Msg.DATA[1]) << 8) + (int)(Msg.DATA[2]);
                    CurrentSensor = sensorRow;
                    textBox濃度.Text = sensorRow.ToString();

                    ///エラーフラグ
                    textBoxステータス情報.Text =
                        ((Msg.DATA[3] & 0x01) == 0x01) ? Msg.DATA[3].ToString("X2") + " : " + Define.defErrorFlag1[0] :
                        ((Msg.DATA[3] & 0x02) == 0x02) ? Msg.DATA[3].ToString("X2") + " : " + Define.defErrorFlag1[1] :
                        ((Msg.DATA[3] & 0x04) == 0x04) ? Msg.DATA[3].ToString("X2") + " : " + Define.defErrorFlag1[2] :
                        ((Msg.DATA[3] & 0x08) == 0x08) ? Msg.DATA[3].ToString("X2") + " : " + Define.defErrorFlag1[3] :
                        ((Msg.DATA[3] & 0x10) == 0x10) ? Msg.DATA[3].ToString("X2") + " : " + Define.defErrorFlag1[4] :
                        ((Msg.DATA[3] & 0x20) == 0x20) ? Msg.DATA[3].ToString("X2") + " : " + Define.defErrorFlag1[5] :
                        ((Msg.DATA[3] & 0x40) == 0x40) ? Msg.DATA[3].ToString("X2") + " : " + Define.defErrorFlag1[6] :
                        ((Msg.DATA[3] & 0x80) == 0x80) ? Msg.DATA[3].ToString("X2") + " : " + Define.defErrorFlag1[7] : Msg.DATA[3].ToString("X2") + ":" + "エラーなし";

                    ///温度
                    int temperatureRow = (Msg.DATA[4] > 128) ? Msg.DATA[4] - 256 : Msg.DATA[4];
                    CurrentTemperature = temperatureRow;
                    textBox温度.Text = temperatureRow.ToString();

                    ///AD値
                    int adcRow = (int)((Msg.DATA[6]) << 8) + (int)(Msg.DATA[7]);
                    textBoxセンサAD値.Text = adcRow.ToString();

                    ///CRC
                    int dataCrc = (int)(Msg.DATA[0] & 0x0F);
                    textBoxCRC.Text = dataCrc.ToString("X1");
                    labelCRC.Text = "チェックサム";

                    ///有効性
                    textBox有効性.Text = "---";

                }
                else if (Type == 2)
                {
                    ///送信カウンタ
                    int counter = (int)(Msg.DATA[1] & 0x0F);
                    textBoxCounter.Text = counter.ToString();

                    ///濃度
                    dataRaw = (int)(Msg.DATA[2]);
                    textBox濃度.Text = (Msg.DATA[2] == 0xFF) ? "Err" : Func.ConvGas1(dataRaw).ToString();
                    CurrentSensor = (Msg.DATA[2] == 0xFF) ? 0 : Func.ConvGas1(dataRaw);

                    ///エラーフラグ
                    textBoxステータス情報.Text =
                        (Msg.DATA[3] == 0x00) ? Msg.DATA[3].ToString("X2") + " : " + Define.defErrorFlag2[0] :
                        (Msg.DATA[3] == 0x06) ? Msg.DATA[3].ToString("X2") + " : " + Define.defErrorFlag2[1] : "---";

                    ///温度
                    int temperatureRow = (Msg.DATA[4] > 128) ? Msg.DATA[4] - 256 : Msg.DATA[4];
                    CurrentTemperature = temperatureRow;
                    textBox温度.Text = temperatureRow.ToString();

                    ///AD値
                    int adcRow = (int)((Msg.DATA[6]) << 8) + (int)(Msg.DATA[7]);
                    textBoxセンサAD値.Text = adcRow.ToString();

                    ///CRC
                    int dataCrc = (int)(Msg.DATA[0]);
                    textBoxCRC.Text = dataCrc.ToString("X2");
                    labelCRC.Text = "CRC8";

                    ///有効性
                    textBox有効性.Text = (Msg.DATA[2] != 0xFF) ? "有効" : "無効";
                }
                else if (Type == 3)
                {
                    ///送信カウンタ
                    int counter = (int)(Msg.DATA[2] & 0x0F);
                    textBoxCounter.Text = counter.ToString();

                    ///濃度
                    dataRaw = (int)(Msg.DATA[0]);
                    textBox濃度.Text = (Msg.DATA[0] == 0xFF) ? "Err" : Func.ConvGas1(dataRaw).ToString();
                    CurrentSensor = (Msg.DATA[0] == 0xFF) ? 0 : Func.ConvGas1(dataRaw);

                    ///エラーフラグ
                    int errorflag = (int)(Msg.DATA[2] & 0x30) >> 4;
                    textBoxステータス情報.Text =
                        (errorflag == 0x00) ? errorflag.ToString("X2") + " : " + Define.defErrorFlag3[0] :
                        (errorflag == 0x01) ? errorflag.ToString("X2") + " : " + Define.defErrorFlag3[1] :
                        (errorflag == 0x03) ? errorflag.ToString("X2") + " : " + Define.defErrorFlag3[2] : "---";

                    ///温度
                    int temperatureRow = (Msg.DATA[3] > 128) ? Msg.DATA[3] - 256 : Msg.DATA[3];
                    CurrentTemperature = temperatureRow;
                    textBox温度.Text = temperatureRow.ToString();

                    ///AD値
                    int adcRow = (int)((Msg.DATA[6]) << 8) + (int)(Msg.DATA[7]);
                    textBoxセンサAD値.Text = adcRow.ToString();

                    ///CRC
                    int dataCrc = (int)((Msg.DATA[1]) << 8) + (int)(Msg.DATA[5]);
                    textBoxCRC.Text = dataCrc.ToString("X4");
                    labelCRC.Text = "CRC16";

                    ///有効性
                    textBox有効性.Text = (Msg.DATA[0] != 0xFF) ? "有効" : "無効";
                }
                else if (Type == 4)
                {
                    ///送信カウンタ
                    int counter = (int)(Msg.DATA[7] & 0x30) >> 4;
                    textBoxCounter.Text = counter.ToString();

                    ///濃度
                    dataRaw = (int)(Msg.DATA[0]);
                    textBox濃度.Text = (Msg.DATA[0] == 0xFF) ? "Err" : Func.ConvGas2(dataRaw).ToString();
                    CurrentSensor = (Msg.DATA[0] == 0xFF) ? 0 : Func.ConvGas2(dataRaw);

                    ///エラーフラグ
                    textBoxステータス情報.Text =
                        ((Msg.DATA[2] & 0x01) == 0x01) ? Msg.DATA[3].ToString("X2") + " : " + Define.defErrorFlag4[0] :
                        ((Msg.DATA[2] & 0x02) == 0x02) ? Msg.DATA[3].ToString("X2") + " : " + Define.defErrorFlag4[1] :
                        ((Msg.DATA[2] & 0x04) == 0x04) ? Msg.DATA[3].ToString("X2") + " : " + Define.defErrorFlag4[2] :
                        ((Msg.DATA[2] & 0x08) == 0x08) ? Msg.DATA[3].ToString("X2") + " : " + Define.defErrorFlag4[3] : "--";

                    ///温度
                    int temperatureRow = (Msg.DATA[3] > 128) ? Msg.DATA[3] - 256 : Msg.DATA[3];
                    CurrentTemperature = temperatureRow;
                    textBox温度.Text = temperatureRow.ToString();

                    ///AD値
                    int adcRow = (int)((Msg.DATA[5]) << 8) + (int)(Msg.DATA[6]);
                    textBoxセンサAD値.Text = adcRow.ToString();

                    ///CRC
                    int dataCrc = (int)(Msg.DATA[7] & 0x0F);
                    textBoxCRC.Text = dataCrc.ToString("X1");
                    labelCRC.Text = "チェックサム";

                    ///有効性
                    textBox有効性.Text = ((Msg.DATA[1] & 0x80) == 0x80) ? "有効" : "無効";
                }

                //生データ

                textReg1.Text = (Msg.DATA[0]).ToString("X2");
                textReg2.Text = (Msg.DATA[1]).ToString("X2");
                textReg3.Text = (Msg.DATA[2]).ToString("X2");
                textReg4.Text = (Msg.DATA[3]).ToString("X2");
                textReg5.Text = (Msg.DATA[4]).ToString("X2");
                textReg6.Text = (Msg.DATA[5]).ToString("X2");
                textReg7.Text = (Msg.DATA[6]).ToString("X2");
                textReg8.Text = (Msg.DATA[7]).ToString("X2");

                ///ログ記録
                ClassData _data = new ClassData();

                _data.TimeStamp = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                _data.MsgFD = Msg;
                _data.Counter = textBoxCounter.Text;
                _data.ErrorFlag = textBoxステータス情報.Text;
                _data.Sensor = textBox濃度.Text;
                _data.Temp = textBox温度.Text;
                _data.AdValue = textBoxセンサAD値.Text;
                _data.Crc = textBoxCRC.Text;
                _data.Valid = textBox有効性.Text;

                Logger.Write(_data);
            } 
        }

        /// <summary>
        /// 
        /// </summary>

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



        /// <summary>
        /// 
        /// </summary>

        private void buttonID_Click(object sender, EventArgs e)
        {
            byte[] srcBuff = new byte[8];

            int idA = Convert.ToInt32(txtIDA.Text, 16);
            int idB = Convert.ToInt32(txtIDB.Text, 16);

            srcBuff[0] = 0x37;
            srcBuff[1] = 0x31;
            srcBuff[2] = (byte)(idA / 256);
            srcBuff[3] = (byte)(idA % 256);
            srcBuff[4] = (byte)(idB / 256);
            srcBuff[5] = (byte)(idB % 256);

            ClassPeripheral.CAN[UnitNo].WriteFrame(srcBuff);

            Thread.Sleep(500);

            int idC = Convert.ToInt32(txtIDC.Text, 16);
            int idD = Convert.ToInt32(txtIDD.Text, 16);

            srcBuff[0] = 0x37;
            srcBuff[1] = 0x35;
            srcBuff[2] = (byte)(idC / 256);
            srcBuff[3] = (byte)(idC % 256);
            srcBuff[4] = (byte)(idD / 256);
            srcBuff[5] = (byte)(idD % 256);

            ClassPeripheral.CAN[UnitNo].WriteFrame(srcBuff);
        }

        private void buttonType_Click(object sender, EventArgs e)
        {
            if      (radioTypeA.Checked) Type = 1;
            else if (radioTypeB.Checked) Type = 2;
            else if (radioTypeC.Checked) Type = 3;
            else if (radioTypeD.Checked) Type = 4;

            byte[] srcBuff = new byte[8];

            srcBuff[0] = 0x37;
            srcBuff[1] = 0x33;
            srcBuff[2] = (byte)Func.int2asc(Type);

            TypeSelect();

            ClassPeripheral.CAN[UnitNo].WriteFrame(srcBuff);
        }

        private void TypeSelect()
        {
            if      (Type == 1) labelType.Text = "TypeA";
            else if (Type == 2) labelType.Text = "TypeB";
            else if (Type == 3) labelType.Text = "TypeC";
            else if (Type == 4) labelType.Text = "TypeD";
            else                labelType.Text = "不明";
        }
    }
}
