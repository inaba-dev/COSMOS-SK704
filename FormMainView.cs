using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TPCANHandle = System.UInt16;
using TPCANBitrateFD = System.String;
using TPCANTimestampFD = System.UInt64;

namespace APP
{
    partial class FormMain
    {
        /// <summary>
        /// 
        /// </summary>

        private void btnHwRefresh()
        {
            if (ClassPeripheral.CAN1 == null
                && ClassPeripheral.CAN2 == null
                && ClassPeripheral.CAN3 == null
                && ClassPeripheral.CAN4 == null
                && ClassPeripheral.CAN5 == null
                && ClassPeripheral.CAN6 == null
                ) return;

            ///一旦データソースを削除
            cbbChannel1.DataSource = null;
            cbbChannel2.DataSource = null;
            cbbChannel3.DataSource = null;
            cbbChannel4.DataSource = null;
            cbbChannel5.DataSource = null;
            cbbChannel6.DataSource = null;

            ///ハードウェアの検索
            List<String> devIndexes1 = ClassPeripheral.CAN1.UpdateDevices();
            List<String> devIndexes2 = ClassPeripheral.CAN2.UpdateDevices();
            List<String> devIndexes3 = ClassPeripheral.CAN3.UpdateDevices();
            List<String> devIndexes4 = ClassPeripheral.CAN4.UpdateDevices();
            List<String> devIndexes5 = ClassPeripheral.CAN5.UpdateDevices();
            List<String> devIndexes6 = ClassPeripheral.CAN6.UpdateDevices();

            ///フォームに反映
            cbbChannel1.DataSource = devIndexes1;
            cbbChannel2.DataSource = devIndexes2;
            cbbChannel3.DataSource = devIndexes3;
            cbbChannel4.DataSource = devIndexes4;
            cbbChannel5.DataSource = devIndexes5;
            cbbChannel6.DataSource = devIndexes6;

            ///フォーカス
            if (cbbChannel1.Items.Count > 0) cbbChannel1.SelectedIndex = 0;
            if (cbbChannel2.Items.Count > 0) cbbChannel2.SelectedIndex = 0;
            if (cbbChannel3.Items.Count > 0) cbbChannel3.SelectedIndex = 0;
            if (cbbChannel4.Items.Count > 0) cbbChannel4.SelectedIndex = 0;
            if (cbbChannel5.Items.Count > 0) cbbChannel5.SelectedIndex = 0;
            if (cbbChannel6.Items.Count > 0) cbbChannel6.SelectedIndex = 0;

            ///
            userControlLogger.Setup(devIndexes1);
        }

        /// <summary>
        /// Inserts a new entry for a new message in the Message-ListView
        /// </summary>

        private List<string> mCanIdList;

        private void InsertMsgEntry(TPCANMsgFD newMsg)
        {
            ClassMessageStatus msgStsCurrentMsg;
            ListViewItem lviCurrentItem;

            // We add this status in the last message list
            msgStsCurrentMsg = new ClassMessageStatus(newMsg, lstMessages.Items.Count);

            string id = msgStsCurrentMsg.IdString;

            //uint id = Convert.ToUInt32(txtID.Text, 16);

            if (!mCanIdList.Contains(id))
            {
                mCanIdList.Add(msgStsCurrentMsg.IdString);

                // Add the new ListView Item with the Type of the message
                lviCurrentItem = lstMessages.Items.Add(msgStsCurrentMsg.TypeString);

                // We set the ID of the message              
                lviCurrentItem.SubItems.Add(msgStsCurrentMsg.IdString);

                // We set the length of the Message
                lviCurrentItem.SubItems.Add(msgStsCurrentMsg.CANMsg.DLC.ToString());

                // We set the data of the message. 	
                lviCurrentItem.SubItems.Add(msgStsCurrentMsg.DataString);
            }
            else
            {
                for (int i = 0; i < mCanIdList.Count; i++)
                {
                    if (mCanIdList[i] == id)
                    {
                        lviCurrentItem = lstMessages.Items[i];

                        lviCurrentItem.SubItems[1].Text = msgStsCurrentMsg.IdString;
                        lviCurrentItem.SubItems[2].Text = msgStsCurrentMsg.CANMsg.DLC.ToString();
                        lviCurrentItem.SubItems[3].Text = msgStsCurrentMsg.DataString;
                    }
                }
            }
        }

        private void SetConnectionStatus()
        {
            if (ClassPeripheral.CAN1 == null 
                && ClassPeripheral.CAN2 == null
                && ClassPeripheral.CAN3 == null
                && ClassPeripheral.CAN4 == null
                && ClassPeripheral.CAN5 == null
                && ClassPeripheral.CAN6 == null) return;

            bool bConnected = 
                ClassPeripheral.CAN1.IsConnect()
                || ClassPeripheral.CAN2.IsConnect()
                || ClassPeripheral.CAN3.IsConnect()
                || ClassPeripheral.CAN4.IsConnect()
                || ClassPeripheral.CAN5.IsConnect()
                || ClassPeripheral.CAN6.IsConnect();

            // Buttons

            buttonConnect.Enabled = !bConnected;
            buttonConnect.BackColor = !bConnected ? Color.DeepSkyBlue : Color.Gray;
            buttonDisConnect.Enabled = bConnected;
            buttonDisConnect.BackColor = bConnected ? Color.Red : Color.Gray;

            // Group

            groupSetup.Enabled = !bConnected;

            // ロギングボタン

            buttonLog.Enabled = bConnected;

            if (bConnected && userControlLogger.IsLogging())
            {
                buttonLog.Text = "ロギング停止";
                buttonLog.BackColor = Color.Red;
            }
            else
            {
                buttonLog.Text = "ロギング開始";
                buttonLog.BackColor = Color.Blue;
            }

            // Logger

            userControlLogger.Enabled = !bConnected;
        }
    }
}
