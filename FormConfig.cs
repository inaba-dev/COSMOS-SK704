using System.Linq;
using System.Collections.Generic;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Collections.ObjectModel;

namespace APP
{
    /// <summary>
    /// XML形式で外部保存するデータクラス
    /// </summary>
    
    partial class FormMain
    {
        /// <summary>
        /// アプリケーションの設定をXMLファイルから取り込む
        /// </summary>
        protected void execLoadConfig()
        {
            try
            {
                ///ボーレート
                this.cbbBaudrates.SelectedIndex = Properties.Settings.Default.Baudrate;

                ///機器選択
                //this.radioModePeak.Checked = Properties.Settings.Default.Device;
                //this.radioModeInno.Checked = !Properties.Settings.Default.Device;

                //if(this.radioModePeak.Checked)
                //{
                //    radioModePeak_CheckedChanged(null, null);
                //}
                //else
                //{
                //    radioModeInno_CheckedChanged(null, null);
                //}

                ClassPeripheral.CAN1 = new ClassInnoCanController();
                ClassPeripheral.CAN2 = new ClassInnoCanController();
                ClassPeripheral.CAN3 = new ClassInnoCanController();
                ClassPeripheral.CAN4 = new ClassInnoCanController();
                ClassPeripheral.CAN5 = new ClassInnoCanController();
                ClassPeripheral.CAN6 = new ClassInnoCanController();

                ///CANセットアップ
                reloadCanSetup();

                ///CAN-ID
                userControlUnits.userControlUnit1.txtID.Text = Properties.Settings.Default.CanId1.ToString("x");
                userControlUnits.userControlUnit2.txtID.Text = Properties.Settings.Default.CanId2.ToString("x");
                userControlUnits.userControlUnit3.txtID.Text = Properties.Settings.Default.CanId3.ToString("x");
                userControlUnits.userControlUnit4.txtID.Text = Properties.Settings.Default.CanId4.ToString("x");
                userControlUnits.userControlUnit5.txtID.Text = Properties.Settings.Default.CanId5.ToString("x");
                userControlUnits.userControlUnit6.txtID.Text = Properties.Settings.Default.CanId6.ToString("x");

                ///Log保存先
                this.userControlUnits.textBoxPath.Text = Properties.Settings.Default.LogPath;


            }
            catch
            {

            }
        }

        /// <summary>
        /// アプリケーションの設定をXMLファイルに保存する
        /// </summary>
        protected void execSaveConfig()
        {
            ///ボーレート
            Properties.Settings.Default.Baudrate = this.cbbBaudrates.SelectedIndex;

            ///機器選択
            Properties.Settings.Default.Device = true;// this.radioModePeak.Checked;

            ///CAN-ID
            if (userControlUnits.userControlUnit1.txtID.Text == "") userControlUnits.userControlUnit1.txtID.Text = "0";
            if (userControlUnits.userControlUnit2.txtID.Text == "") userControlUnits.userControlUnit2.txtID.Text = "0";
            if (userControlUnits.userControlUnit3.txtID.Text == "") userControlUnits.userControlUnit3.txtID.Text = "0";
            if (userControlUnits.userControlUnit4.txtID.Text == "") userControlUnits.userControlUnit4.txtID.Text = "0";
            if (userControlUnits.userControlUnit5.txtID.Text == "") userControlUnits.userControlUnit5.txtID.Text = "0";
            if (userControlUnits.userControlUnit6.txtID.Text == "") userControlUnits.userControlUnit6.txtID.Text = "0";

            Properties.Settings.Default.CanId1 = Convert.ToUInt32(userControlUnits.userControlUnit1.txtID.Text, 16);
            Properties.Settings.Default.CanId2 = Convert.ToUInt32(userControlUnits.userControlUnit2.txtID.Text, 16);
            Properties.Settings.Default.CanId3 = Convert.ToUInt32(userControlUnits.userControlUnit3.txtID.Text, 16);
            Properties.Settings.Default.CanId4 = Convert.ToUInt32(userControlUnits.userControlUnit4.txtID.Text, 16);
            Properties.Settings.Default.CanId5 = Convert.ToUInt32(userControlUnits.userControlUnit5.txtID.Text, 16);
            Properties.Settings.Default.CanId6 = Convert.ToUInt32(userControlUnits.userControlUnit6.txtID.Text, 16);

            ///Log保存先
            Properties.Settings.Default.LogPath = this.userControlUnits.textBoxPath.Text;

            ///Save
            Properties.Settings.Default.Save();
        }
    }
}
