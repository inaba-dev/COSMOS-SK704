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

                ///有効
                checkCh1.Checked = Properties.Settings.Default.Valid1;
                checkCh2.Checked = Properties.Settings.Default.Valid2;
                checkCh3.Checked = Properties.Settings.Default.Valid3;
                checkCh4.Checked = Properties.Settings.Default.Valid4;
                checkCh5.Checked = Properties.Settings.Default.Valid5;
                checkCh6.Checked = Properties.Settings.Default.Valid6;

                ///CANセットアップ
                reloadCanSetup();

                ///CAN-ID
                userControlUnits.userControlStatus1.txtID.Text = Properties.Settings.Default.CanId1.ToString("x");
                userControlUnits.userControlStatus2.txtID.Text = Properties.Settings.Default.CanId2.ToString("x");
                userControlUnits.userControlStatus3.txtID.Text = Properties.Settings.Default.CanId3.ToString("x");
                userControlUnits.userControlStatus4.txtID.Text = Properties.Settings.Default.CanId4.ToString("x");
                userControlUnits.userControlStatus5.txtID.Text = Properties.Settings.Default.CanId5.ToString("x");
                userControlUnits.userControlStatus6.txtID.Text = Properties.Settings.Default.CanId6.ToString("x");

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

            ///拡張
            Properties.Settings.Default.Extender = this.checkExtender.Checked;

            ///有効
            Properties.Settings.Default.Valid1 = checkCh1.Checked;
            Properties.Settings.Default.Valid2 = checkCh2.Checked;
            Properties.Settings.Default.Valid3 = checkCh3.Checked;
            Properties.Settings.Default.Valid4 = checkCh4.Checked;
            Properties.Settings.Default.Valid5 = checkCh5.Checked;
            Properties.Settings.Default.Valid6 = checkCh6.Checked;

            ///CAN-ID
            if (userControlUnits.userControlStatus1.txtID.Text == "") userControlUnits.userControlStatus1.txtID.Text = "0";
            if (userControlUnits.userControlStatus2.txtID.Text == "") userControlUnits.userControlStatus2.txtID.Text = "0";
            if (userControlUnits.userControlStatus3.txtID.Text == "") userControlUnits.userControlStatus3.txtID.Text = "0";
            if (userControlUnits.userControlStatus4.txtID.Text == "") userControlUnits.userControlStatus4.txtID.Text = "0";
            if (userControlUnits.userControlStatus5.txtID.Text == "") userControlUnits.userControlStatus5.txtID.Text = "0";
            if (userControlUnits.userControlStatus6.txtID.Text == "") userControlUnits.userControlStatus6.txtID.Text = "0";

            Properties.Settings.Default.CanId1 = Convert.ToUInt32(userControlUnits.userControlStatus1.txtID.Text, 16);
            Properties.Settings.Default.CanId2 = Convert.ToUInt32(userControlUnits.userControlStatus2.txtID.Text, 16);
            Properties.Settings.Default.CanId3 = Convert.ToUInt32(userControlUnits.userControlStatus3.txtID.Text, 16);
            Properties.Settings.Default.CanId4 = Convert.ToUInt32(userControlUnits.userControlStatus4.txtID.Text, 16);
            Properties.Settings.Default.CanId5 = Convert.ToUInt32(userControlUnits.userControlStatus5.txtID.Text, 16);
            Properties.Settings.Default.CanId6 = Convert.ToUInt32(userControlUnits.userControlStatus6.txtID.Text, 16);

            ///Log保存先
            Properties.Settings.Default.LogPath = this.userControlUnits.textBoxPath.Text;

            ///Save
            Properties.Settings.Default.Save();
        }
    }
}
