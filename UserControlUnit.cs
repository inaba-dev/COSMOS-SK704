using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP
{
    public partial class UserControlUnit : UserControl
    {
        public ClassLogger Logger = new ClassLogger();

        public double CurrentSensor = 0.0;
        public double CurrentTemperature = 0.0;
        public double CurrentHumidity = 0.0;

        private uint UnitId = 0x0000;
        private uint CmdId = 0x0000;
        private int UnitNo;

        public UserControlUnit()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>

        public void Initialize(int unit)
        {
            UnitNo = unit;
        }

        /// <summary>
        /// 
        /// </summary>

        public void SetEnable(bool bConnected)
        {
            if (!bConnected)
            {
                this.hardware.Enabled = true;
                this.txtID.Enabled = true;
                this.checkValid.Enabled = true;
                this.Enabled = true;
            }
            else
            {
                if (ClassPeripheral.CAN[UnitNo].IsConnect())
                {
                    this.hardware.Enabled = false;
                    this.txtID.Enabled = false;
                    this.checkValid.Enabled = false;
                    this.Enabled = true;
                }
                else
                {
                    this.hardware.Enabled = true;
                    this.txtID.Enabled = true;
                    this.checkValid.Enabled = true;
                    this.Enabled = false;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>

        public void HWSetup(List<string> devices)
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

        static int times = 0;

        public void Display(TPCANMsgFD Msg)
        {
            int cmd1, cmd2, cmd3;
            int cmd;

            string str;

            if (!ClassPeripheral.CAN[UnitNo].IsConnect()) return;

            UnitId = checkExtender.Checked ? (0x1FFF << 16) + Convert.ToUInt32(txtID.Text, 16) : Convert.ToUInt32(txtID.Text, 16);
            CmdId  = checkExtender.Checked ? (0x1FFF << 16) + Define.CMD_PACKET_TYPE_EXT_ID : Define.CMD_PACKET_TYPE_STD_ID;

            if (Msg.ID == UnitId && HWInfo() == Msg.DEVICE)
            {
                times++;
                Console.WriteLine("recv:{0}", times);
                ///送信カウンタ
                int counter = (int)(Msg.DATA[0]);
                textBoxCounter.Text = counter.ToString();

                ///濃度
                int sensorRow = (int)(Msg.DATA[2]) - (int)(Msg.DATA[3]);
                CurrentSensor = sensorRow;
                textBox濃度.Text = sensorRow.ToString();

                ///温度
                int temperatureRow = (Msg.DATA[5] > 128) ? Msg.DATA[5] - 256 : Msg.DATA[5];
                CurrentTemperature = temperatureRow;
                textBox温度.Text = temperatureRow.ToString();

                ///エラーフラグ
                textBoxエラーフラグ.Text = Msg.DATA[3].ToString("X2");
                textBoxエラー情報.Text =
                    ((Msg.DATA[3] & 0x01) == 0x01) ? Define.defErrorFlag[0] :
                    ((Msg.DATA[3] & 0x02) == 0x02) ? Define.defErrorFlag[1] :
                    ((Msg.DATA[3] & 0x04) == 0x04) ? Define.defErrorFlag[2] :
                    ((Msg.DATA[3] & 0x08) == 0x08) ? Define.defErrorFlag[3] :
                    ((Msg.DATA[3] & 0x10) == 0x10) ? Define.defErrorFlag[4] :
                    ((Msg.DATA[3] & 0x20) == 0x20) ? Define.defErrorFlag[5] :
                    ((Msg.DATA[3] & 0x40) == 0x40) ? Define.defErrorFlag[6] :
                    ((Msg.DATA[3] & 0x80) == 0x80) ? Define.defErrorFlag[7] : "--";

                ///AD値種別
                textBoxステータスフラグ.Text = Msg.DATA[4].ToString("X2");
                textBoxステータス情報.Text =
                    ((Msg.DATA[4] & 0x01) == 0x01) ? Define.defStatusFlag[0] :
                    ((Msg.DATA[4] & 0x02) == 0x02) ? Define.defStatusFlag[1] :
                    ((Msg.DATA[4] & 0x04) == 0x04) ? Define.defStatusFlag[2] :
                    ((Msg.DATA[4] & 0x08) == 0x08) ? Define.defStatusFlag[3] :
                    ((Msg.DATA[4] & 0x10) == 0x10) ? Define.defStatusFlag[4] :
                    ((Msg.DATA[4] & 0x20) == 0x20) ? Define.defStatusFlag[5] :
                    ((Msg.DATA[4] & 0x40) == 0x40) ? Define.defStatusFlag[6] : "--";

                ///ログ記録
                Logger.Write(Msg);
            }

            if (Msg.ID == CmdId && HWInfo() == Msg.DEVICE)
            {
                if (ClassPeripheral.CAN[UnitNo].IsCommandMode())
                {
                    //Console.WriteLine("[recv] {0}byte -----------------", Msg.DATA.Length);
                    //for (int i = 0; i < Msg.DATA.Length; i++) Console.WriteLine("send[{0}] : {1:X2}", i, Msg.DATA[i]);

                    if (Msg.DATA[3] == '=')
                    {
                        cmd1 = Func.asc2int(Msg.DATA[0]);
                        cmd2 = Func.asc2int(Msg.DATA[1]);
                        cmd3 = Func.asc2int(Msg.DATA[2]);

                        cmd = cmd1 * 100 + cmd2 * 10 + cmd3;

                        str = Encoding.ASCII.GetString(Msg.DATA, 4, 4);

                        textBoxReg読出し.Text = str;

                        Console.WriteLine("Command:{0}, Data:{1}", cmd, str);

                        ClassPeripheral.CAN[UnitNo].ClearCommandMode();

                        return;
                    }
                }

                if (Msg.DLC < 8) return;

                cmd1 = Func.asc2int(Msg.DATA[0]);
                cmd2 = Func.asc2int(Msg.DATA[1]);

                cmd = cmd1 * 10 + cmd2;

                switch (cmd)
                {
                    ///ソフトバージョン
                    case 50:

                        str = Encoding.ASCII.GetString(Msg.DATA, 2, 6);

                        textBoxバージョン.Text = str;

                        break;

                    ///オフセット
                    case 51:

                        str = Encoding.ASCII.GetString(Msg.DATA, 2, 6);

                        textBoxオフセット.Text = str;

                        break;

                    ///0ppm
                    case 52:

                        str = Encoding.ASCII.GetString(Msg.DATA, 2, 6);

                        textBox0ppm.Text = str;

                        break;

                    ///20000ppm
                    case 53:

                        str = Encoding.ASCII.GetString(Msg.DATA, 2, 6);

                        textBox20000ppm.Text = str;

                        break;

                    ///水素
                    /*
                    case 54:

                        str = Encoding.ASCII.GetString(Msg.DATA, 2, 6);

                        if (Double.TryParse(str, out value))
                        {
                            textBox水素.Text = str;
                        }

                        break;
                    */
                    ///温度
                    /*
                    case 55:

                        str = Encoding.ASCII.GetString(Msg.DATA, 2, 4);

                        if (Double.TryParse(str, out value))
                        {
                            textBoxサーミスタ.Text = str;
                        }

                        break;
                    */
                    ///中間電圧
                    /*
                    case 56:

                            str = Encoding.ASCII.GetString(Msg.DATA, 2, 6);

                            textBox中間電圧.Text = str;

                            break;
                    */
                    ///製造番号
                    case 58:

                        str = Encoding.ASCII.GetString(Msg.DATA, 2, 6);

                        textBox製造番号.Text = str;

                        break;

                    default:

                        break;
                }
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

        private void buttonFlashInit_Click(object sender, EventArgs e)
        {
            //メッセージボックスを表示する
            DialogResult result = MessageBox.Show("フラッシュを初期化しますか？？", "初期化の確認",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2);

            //何が選択されたか調べる
            if (result == DialogResult.Yes)
            {
                byte[] srcBuff = new byte[8];

                srcBuff[0] = (byte)'c';
                srcBuff[1] = (byte)'0';
                srcBuff[2] = (byte)'1';
                srcBuff[3] = (byte)'0';
                srcBuff[4] = (byte)'0';
                srcBuff[5] = (byte)'0';
                srcBuff[6] = (byte)'0';
                srcBuff[7] = (byte)'1';

                ClassPeripheral.CAN[UnitNo].WriteFrame(srcBuff);
            }
        }

        /// <summary>
        /// 
        /// </summary>

        private void buttonSetオフセット_Click(object sender, EventArgs e)
        {
            ASCIIEncoding ascii = new ASCIIEncoding();

            Byte[] bytes = ascii.GetBytes(numericオフセット.Value.ToString());

            byte[] srcBuff = new byte[8];

            srcBuff[0] = 0x36;
            srcBuff[1] = 0x31;

            for (int i = 0; i < bytes.Length; i++)
            {
                try { srcBuff[2 + i] = bytes[i]; }
                catch { }
            }

            ClassPeripheral.CAN[UnitNo].WriteFrame(srcBuff);
        }

        private void buttonSet0ppm_Click(object sender, EventArgs e)
        {
            ASCIIEncoding ascii = new ASCIIEncoding();

            Byte[] bytes = ascii.GetBytes(numeric0ppm.Value.ToString());

            byte[] srcBuff = new byte[8];

            srcBuff[0] = 0x36;
            srcBuff[1] = 0x32;

            for (int i = 0; i < bytes.Length; i++)
            {
                try { srcBuff[2 + i] = bytes[i]; }
                catch { }
            }

            ClassPeripheral.CAN[UnitNo].WriteFrame(srcBuff);
        }

        private void buttonSet20000ppm_Click(object sender, EventArgs e)
        {
            ASCIIEncoding ascii = new ASCIIEncoding();

            Byte[] bytes = ascii.GetBytes(numeric20000ppm.Value.ToString());

            byte[] srcBuff = new byte[8];

            srcBuff[0] = 0x36;
            srcBuff[1] = 0x33;

            for (int i = 0; i < bytes.Length; i++)
            {
                try { srcBuff[2 + i] = bytes[i]; }
                catch { }
            }

            ClassPeripheral.CAN[UnitNo].WriteFrame(srcBuff);
        }

        private void buttonSet製造番号_Click(object sender, EventArgs e)
        {
            ASCIIEncoding ascii = new ASCIIEncoding();

            Byte[] bytes = ascii.GetBytes(textBox製造番号W.Text);

            byte[] srcBuff = new byte[8];

            srcBuff[0] = 0x36;
            srcBuff[1] = 0x38;


            for (int i = 0; i < bytes.Length; i++)
            {
                try { srcBuff[2 + i] = bytes[i]; }
                catch { }
            }

            Console.WriteLine("[send] {0}byte -----------------", srcBuff.Length);
            for (int i = 0; i < srcBuff.Length; i++) Console.WriteLine("send[{0}] : {1:X2}", i, srcBuff[i]);

            ClassPeripheral.CAN[UnitNo].WriteFrame(srcBuff);
        }

        /// <summary>
        /// 
        /// </summary>

        private void buttonGetバージョン_Click(object sender, EventArgs e)
        {
            byte[] srcBuff = new byte[8];

            srcBuff[0] = 0x31;
            srcBuff[1] = 0x30;

            ClassPeripheral.CAN[UnitNo].WriteFrame(srcBuff);
        }

        private void buttonGetオフセット_Click(object sender, EventArgs e)
        {
            byte[] srcBuff = new byte[8];

            srcBuff[0] = 0x31;
            srcBuff[1] = 0x31;

            ClassPeripheral.CAN[UnitNo].WriteFrame(srcBuff);
        }

        private void buttonGet0ppm_Click(object sender, EventArgs e)
        {
            byte[] srcBuff = new byte[8];

            srcBuff[0] = 0x31;
            srcBuff[1] = 0x32;

            ClassPeripheral.CAN[UnitNo].WriteFrame(srcBuff);
        }

        private void buttonGet20000ppm_Click(object sender, EventArgs e)
        {
            byte[] srcBuff = new byte[8];

            srcBuff[0] = 0x31;
            srcBuff[1] = 0x33;

            ClassPeripheral.CAN[UnitNo].WriteFrame(srcBuff);
        }

        private void buttonGet水素_Click(object sender, EventArgs e)
        {
            byte[] srcBuff = new byte[8];

            srcBuff[0] = 0x31;
            srcBuff[1] = 0x34;

            ClassPeripheral.CAN[UnitNo].WriteFrame(srcBuff);
        }

        private void buttonGetサーミスタ_Click(object sender, EventArgs e)
        {
            byte[] srcBuff = new byte[8];

            srcBuff[0] = 0x31;
            srcBuff[1] = 0x35;

            ClassPeripheral.CAN[UnitNo].WriteFrame(srcBuff);
        }

        private void buttonGet中間電圧_Click(object sender, EventArgs e)
        {
            byte[] srcBuff = new byte[8];

            srcBuff[0] = 0x31;
            srcBuff[1] = 0x36;

            ClassPeripheral.CAN[UnitNo].WriteFrame(srcBuff);
        }

        private void buttonGet製造番号_Click(object sender, EventArgs e)
        {
            byte[] srcBuff = new byte[8];

            srcBuff[0] = 0x31;
            srcBuff[1] = 0x38;

            ClassPeripheral.CAN[UnitNo].WriteFrame(srcBuff);
        }

        /// <summary>
        /// 
        /// </summary>

        private void buttonRegRead_Click(object sender, EventArgs e)
        {
            byte[] srcBuff = new byte[8];

            int cmd = (int)numericCommand.Value;

            srcBuff[0] = (byte)'?';
            srcBuff[1] = (byte)'c';
            srcBuff[2] = (byte)'h';
            srcBuff[3] = cmd >= 100 ? (byte)(Func.int2asc(cmd / 100)) : (byte)' ';
            srcBuff[4] = cmd >= 10 ? (byte)(Func.int2asc((cmd % 100) / 10)) : (byte)' ';
            srcBuff[5] = (byte)(Func.int2asc(cmd % 10));

            ClassPeripheral.CAN[UnitNo].CmdFrame(srcBuff);
        }

        /// <summary>
        /// 
        /// </summary>

        private void buttonA1_Click(object sender, EventArgs e)
        {
            byte[] srcBuff = new byte[8];

            srcBuff[0] = 0x61;
            srcBuff[1] = 0x31;

            ClassPeripheral.CAN[UnitNo].WriteFrame(srcBuff);
        }

        private void buttonA3_Click(object sender, EventArgs e)
        {
            byte[] srcBuff = new byte[8];

            srcBuff[0] = 0x61;
            srcBuff[1] = 0x33;

            ClassPeripheral.CAN[UnitNo].WriteFrame(srcBuff);
        }

        /// <summary>
        /// 
        /// </summary>

        public void TypeSet(int mode)
        {
            byte[] srcBuff = new byte[8];

            srcBuff[0] = 0x37;
            srcBuff[1] = 0x33;
            srcBuff[2] = (byte)Func.int2asc(mode);

            ClassPeripheral.CAN[UnitNo].WriteFrame(srcBuff);
        }

    }
}
