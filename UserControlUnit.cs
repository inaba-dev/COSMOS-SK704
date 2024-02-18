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
        public double CurrentSensor = 0.0;
        public double CurrentTemperature = 0.0;
        public double CurrentHumidity = 0.0;

        public UserControlUnit()
        {
            InitializeComponent();
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

        public void Display(byte[] data)
        {
            if(radioLeakage.Checked)
            {
                ///送信カウンタ
                double counter = Func.ConvSequNumber(data[1] & 0x0F);
                textBoxCounter.Text = counter.ToString();

                ///H2C
                int sensorRow = (int)((data[3] & 0x0F) << 8) + (int)(data[2]);
                CurrentSensor = Func.ConvSensorLeakage(sensorRow);
                textBoxセンサRAW.Text = sensorRow.ToString();
                textBoxセンサ値.Text = CurrentSensor.ToString();

                ///気温
                int temperatureRow = (int)(data[4] << 4) + (int)((data[3] & 0xF0) >> 4);
                CurrentTemperature = Func.ConvTemperatureLeakage(temperatureRow);
                textBox温度RAW.Text = temperatureRow.ToString();
                textBox温度.Text = CurrentTemperature.ToString();

                ///湿度
                int HumidityRaw = (int)(data[5]);
                CurrentHumidity = Func.ConvHumidity(HumidityRaw);
                textBox湿度RAW.Text = HumidityRaw.ToString();
                textBox湿度.Text = CurrentHumidity.ToString();

                ///診断情報
                string DiagInfo = Convert.ToString(((data[1] & 0xF0) >> 4), 2).PadLeft(4, '0'); ;

                ///SW Version
                string SWVersion = data[6].ToString();

                ///HW Version
                string HWVersion = (data[7] & 0x0F).ToString();

                textBoxバージョン情報.Text = "HW:" + HWVersion + "/" + "SW:" + SWVersion;
                textBoxエラー情報.Text = "DiagInfo:" + DiagInfo;
            }
            else
            {
                ///送信カウンタ
                double counter = Func.ConvSequNumber(data[1]);
                textBoxCounter.Text = counter.ToString();

                ///H2C
                int sensorRow = (int)data[2];
                CurrentSensor = Func.ConvSensorExhaust(sensorRow);
                textBoxセンサRAW.Text = sensorRow.ToString();
                textBoxセンサ値.Text = CurrentSensor.ToString();

                ///気温
                int temperatureRow = (int)(data[4] << 8) + (int)(data[3]);
                CurrentTemperature = Func.ConvTemperatureExhaust(temperatureRow);
                textBox温度RAW.Text = temperatureRow.ToString();
                textBox温度.Text = CurrentTemperature.ToString();

                ///湿度
                textBox湿度RAW.Text = "--";
                textBox湿度.Text = "--";

                ///エラーフラグ
                string ErrorMsg = (data[5] & 0x07).ToString();

                ///診断情報
                string DiagInfo = ((data[5] & 0xF8) >> 3).ToString();

                ///SW Version
                string SWVersion = data[6].ToString();

                ///HW Version
                string HWVersion = (data[7] & 0x1F).ToString();

                ///HW Type
                string HWType = (data[7] >> 5).ToString();

                textBoxバージョン情報.Text = "HW:" + HWVersion + "/" + "SW:" + SWVersion + "/" + "TYPE:" + HWType;
                textBoxエラー情報.Text = "Error:" + ErrorMsg + "/" + "DiagInfo:" + DiagInfo;
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
    }
}
