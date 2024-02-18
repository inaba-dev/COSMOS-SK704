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
    public class ClassPeakCanController : ClassCanUsb
    {
        ///
        private uint CAN_ID = 0x202;
        private byte CAN_LEN = 8;
        private bool CAN_EXT = false;

        /// Read-Delegate Handler
        private delegate void ReadDelegateHandler();

        /// Saves the handle of a PCAN hardware
        private TPCANHandle m_PcanHandle;

        /// Stores the status of received messages for its display
        private System.Collections.ArrayList m_LastMsgsList;

        /// Read Delegate for calling the function "ReadMessages"
        //private ReadDelegateHandler m_ReadDelegate;

        /// Thread for message reading (using events)
        private System.Threading.Thread m_ReadThread;

        /// Handles of non plug and play PCAN-Hardware
        private TPCANHandle[] m_NonPnPHandles;
        ///
        public event EventHandler<TPCANMsgFD> m_ReceiveEvent;

        private List<String> m_Devices = new List<string>();

        ///
        private bool bCommandFlag = false;

        /// 接続状況
        private bool bConnect = false;

        /// 排他制御のオブジェクト
        static Object LockWriteSequence = new Object();

        /// <summary>
        /// 
        /// </summary>

        public bool IsConnect() { return bConnect; }
        public bool IsCommandMode() { return bCommandFlag; }
        public void ClearCommandMode() { bCommandFlag = false; }

        public int GetNonPnPHandlesLength() { return m_NonPnPHandles.Length; }

        public string GetFormatChannelName(int index) { return FormatChannelName(m_NonPnPHandles[index]); }
        public string GetFormatChannelName(TPCANHandle handle) { return FormatChannelName(handle); }

        public void ErrorMsg(TPCANStatus stsResult) { MessageBox.Show(GetFormatedError(stsResult));}
               
        /// <summary>
        /// 
        /// </summary>

        public void Init()
        {
            m_LastMsgsList = new System.Collections.ArrayList();

            m_NonPnPHandles = new TPCANHandle[]
            {
            };
        }

        /// <summary>
        /// 
        /// </summary>

        public bool Connect(uint canid, int index, bool extended)
        {
            if (index < 0) return false;

            CAN_ID = canid;
            CAN_EXT = extended;

            try
            {
#if !TESTMODE
                bool bNonPnP;
                string strTemp;

                TPCANStatus stsResult;

                // Get the handle fromt he text being shown
                strTemp = m_Devices[index];
                strTemp = strTemp.Substring(strTemp.IndexOf('(') + 1, 3);

                strTemp = strTemp.Replace('h', ' ').Trim(' ');

                // Determines if the handle belong to a No Plug&Play hardware 
                m_PcanHandle = Convert.ToUInt16(strTemp, 16);
                bNonPnP = m_PcanHandle <= PCANBasic.PCAN_DNGBUS1;

                stsResult = PCANBasic.Initialize(
                    m_PcanHandle,
                    m_Baudrate,
                    TPCANType.PCAN_TYPE_ISA,
                    Convert.ToUInt32(256),
                    Convert.ToUInt16(3));

                if (stsResult != TPCANStatus.PCAN_ERROR_OK)
                {
                    if (stsResult != TPCANStatus.PCAN_ERROR_CAUTION)
                    {
                        MessageBox.Show(GetFormatedError(stsResult));
                    }
                    else
                    {
                        stsResult = TPCANStatus.PCAN_ERROR_OK;
                    }
                }

                bConnect = (stsResult == TPCANStatus.PCAN_ERROR_OK);
#else
                bConnect = true;
#endif

                return bConnect;

            }
            catch
            {
                bConnect = false;

                return bConnect;
            }
        }

        /// <summary>
        /// 切断
        /// </summary>

        public void DisConnect()
        {
            // Releases a current connected PCAN-Basic channel
            PCANBasic.Uninitialize(m_PcanHandle);

            if (m_ReadThread != null)
            {
                m_ReadThread.Abort();
                m_ReadThread.Join();
                m_ReadThread = null;
            }

            bConnect = false;
        }

        /// <summary>
        /// Help Function used to get an error as text
        /// </summary>
        /// <param name="error">Error code to be translated</param>
        /// <returns>A text with the translated error</returns>
        
        private string GetFormatedError(TPCANStatus error)
        {
            StringBuilder strTemp;

            // Creates a buffer big enough for a error-text

            strTemp = new StringBuilder(256);

            // Gets the text using the GetErrorText API function
            // If the function success, the translated error is returned. If it fails,
            // a text describing the current error is returned.

            if (PCANBasic.GetErrorText(error, 0, strTemp) != TPCANStatus.PCAN_ERROR_OK)
                return string.Format("An error occurred. Error-code's text (0x{0:X}) couldn't be retrieved", error);
            else
                return strTemp.ToString();
        }

        /// <summary>
        /// Gets the formated text for a PCAN-Basic channel handle
        /// </summary>
        /// <param name="handle">PCAN-Basic Handle to format</param>
        /// <returns>The formatted text for a channel</returns>

        private string FormatChannelName(TPCANHandle handle)
        {
            TPCANDevice devDevice;
            byte byChannel;

            // Gets the owner device and channel for a 
            // PCAN-Basic handle
            
            if (handle < 0x100)
            {
                devDevice = (TPCANDevice)(handle >> 4);
                byChannel = (byte)(handle & 0xF);
            }
            else
            {
                devDevice = (TPCANDevice)(handle >> 8);
                byChannel = (byte)(handle & 0xFF);
            }

            // Constructs the PCAN-Basic Channel name and return it
            return string.Format("{0} {1} ({2:X2}h)", devDevice, byChannel, handle);
        }

        /// <summary>
        /// 
        /// </summary>

        public void ReadMessages()
        {
            TPCANStatus stsResult;
            do
            {
                stsResult = ReadMessage();

                if (stsResult == TPCANStatus.PCAN_ERROR_ILLOPERATION)
                {
                    break;
                }
            } while (bConnect && (!Convert.ToBoolean(stsResult & TPCANStatus.PCAN_ERROR_QRCVEMPTY)));

        }

        private TPCANStatus ReadMessage()
        {
            TPCANMsg CANMsg;
            TPCANStatus stsResult;
            
            stsResult = PCANBasic.Read(m_PcanHandle, out CANMsg);

            if (stsResult != TPCANStatus.PCAN_ERROR_QRCVEMPTY)
                ProcessMessage(CANMsg);

            return stsResult;
        }

        /// <summary>
        /// 
        /// </summary>

        private void ProcessMessage(TPCANMsg theMsg)
        {
            TPCANMsgFD newMsg;

            newMsg = new TPCANMsgFD();
            newMsg.DATA = new byte[64];
            newMsg.ID = theMsg.ID;
            newMsg.DLC = theMsg.LEN;

            for (int i = 0; i < ((theMsg.LEN > 8) ? 8 : theMsg.LEN); i++)
            {
                newMsg.DATA[i] = theMsg.DATA[i];
            }

            newMsg.MSGTYPE = theMsg.MSGTYPE;

            m_ReceiveEvent(this, newMsg);
        }

        /// <summary>
        /// 
        /// </summary>

        public bool CmdFrame(byte[] srcBuff)
        {
            ///コマンドフラグをON
            bCommandFlag = true;

            return WriteFrame(srcBuff);
        }

        public bool WriteFrame(byte[] srcBuff)
        {
            lock (LockWriteSequence)
            {
                TPCANMsg CANMsg;

                // We create a TPCANMsg message structure 

                CANMsg = new TPCANMsg();
                CANMsg.DATA = new byte[8];

                CANMsg.ID = CAN_ID;
                CANMsg.LEN = CAN_LEN;

                CANMsg.MSGTYPE = (CAN_EXT) ? TPCANMessageType.PCAN_MESSAGE_EXTENDED : TPCANMessageType.PCAN_MESSAGE_STANDARD;

                for (int i = 0; i < CANMsg.LEN; i++)
                {
                    CANMsg.DATA[i] = srcBuff[i];
                }

                // The message is sent to the configured hardware

                return (PCANBasic.Write(m_PcanHandle, ref CANMsg) == TPCANStatus.PCAN_ERROR_OK);
            }
        }

        /// <summary>
        /// 
        /// </summary>

        public List<String> UpdateDevices()
        {
            TPCANStatus stsResult;
            uint iChannelsCount;
            bool bIsFD;

            m_Devices.Clear();

            try
            {
                stsResult = PCANBasic.GetValue(PCANBasic.PCAN_NONEBUS, TPCANParameter.PCAN_ATTACHED_CHANNELS_COUNT, out iChannelsCount, sizeof(uint));
                if (stsResult == TPCANStatus.PCAN_ERROR_OK)
                {
                    TPCANChannelInformation[] info = new TPCANChannelInformation[iChannelsCount];

                    stsResult = PCANBasic.GetValue(PCANBasic.PCAN_NONEBUS, TPCANParameter.PCAN_ATTACHED_CHANNELS, info);
                    if (stsResult == TPCANStatus.PCAN_ERROR_OK)
                    {
                        // Include only connectable channels
                        foreach (TPCANChannelInformation channel in info)
                        {
                            if ((channel.channel_condition & PCANBasic.PCAN_CHANNEL_AVAILABLE) == PCANBasic.PCAN_CHANNEL_AVAILABLE)
                            {
                                bIsFD = (channel.device_features & PCANBasic.FEATURE_FD_CAPABLE) == PCANBasic.FEATURE_FD_CAPABLE;
                                m_Devices.Add(GetFormatChannelName(channel.channel_handle));
                            }
                        }
                    }
                }

                if (stsResult != TPCANStatus.PCAN_ERROR_OK)
                    ErrorMsg(stsResult);
            }
            catch (DllNotFoundException)
            {
                MessageBox.Show("Unable to find the library: PCANBasic.dll !", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return m_Devices;
        }

        /// <summary>
        /// 
        /// </summary>

        private TPCANBaudrate m_Baudrate;

        public void cbbBaudrates_SelectedIndexChanged(int index)
        {
            switch (index)
            {
                case 0:
                    m_Baudrate = TPCANBaudrate.PCAN_BAUD_1M;
                    break;
                case 1:
                    m_Baudrate = TPCANBaudrate.PCAN_BAUD_800K;
                    break;
                case 2:
                    m_Baudrate = TPCANBaudrate.PCAN_BAUD_500K;
                    break;
                case 3:
                    m_Baudrate = TPCANBaudrate.PCAN_BAUD_250K;
                    break;
                case 4:
                    m_Baudrate = TPCANBaudrate.PCAN_BAUD_125K;
                    break;
                case 5:
                    m_Baudrate = TPCANBaudrate.PCAN_BAUD_100K;
                    break;
                case 6:
                    m_Baudrate = TPCANBaudrate.PCAN_BAUD_83K;
                    break;
                case 7:
                    m_Baudrate = TPCANBaudrate.PCAN_BAUD_50K;
                    break;
                case 8:
                    m_Baudrate = TPCANBaudrate.PCAN_BAUD_33K;
                    break;
                case 9:
                    m_Baudrate = TPCANBaudrate.PCAN_BAUD_20K;
                    break;
                default:
                    m_Baudrate = TPCANBaudrate.PCAN_BAUD_500K;
                    break;
            }
        }
    }
}
