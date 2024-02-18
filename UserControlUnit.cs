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
