using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using InnoMakerUsb2CanLib;
using System.Threading;
using System.Collections.Concurrent;

namespace APP
{
    public class ClassInnoCanController
    {
        private uint CAN_ID = 0x202;
        private byte CAN_LEN = 8;
        private bool CAN_EXT = false;

        public event EventHandler<TPCANMsgFD> m_ReceiveEvent;

        ///
        private bool bCommandFlag = false;

        /// 接続状況
        private bool bConnect = false;

        /// 排他制御のオブジェクト
        static Object LockWriteSequence = new Object();

        public bool IsConnect() { return bConnect; }
        public bool IsCommandMode() { return bCommandFlag; }
        public void ClearCommandMode() { bCommandFlag = false; }
        
        /// <summary>
        /// Frame Format
        /// </summary>

        enum FrameFormat
        {
            FrameFormatStandard = 0
        }

        /// <summary>
        /// Frame Type
        /// </summary>
        enum FrameType
        {
            FrameTypeData = 0
        }

        /// <summary>
        /// Can Mode
        /// </summary>
        enum CanMode
        {
            CanModeNormal = 0
        }

        /// <summary>
        /// Check ID Type
        /// </summary>
        enum CheckIDType
        {
            CheckIDTypeNone = 0,
            CheckIDTypeIncrease = 1
        }

        /// <summary>
        /// Check Data Type
        /// </summary>
        enum CheckDataType
        {
            CheckDataTypeNone = 0,
            CheckDataTypeIncrease = 1
        }

        /// <summary>
        /// Check Error Frame 
        /// </summary>
        enum CheckErrorFrame
        {
            CheckErrorFrameClose = 0,
            CheckErrorFrameOpen = 1
        }

        /// <summary>
        /// System Language
        /// </summary>
        enum SystemLanguage
        {
            DefaultLanguage = 0,
            EnglishLanguage = 1,
            ChineseLanguage = 2
        }

        [DllImport("User32.dll")]
        public static extern void PostMessage(IntPtr hWnd, int msg, int wParam, ref My_lParam lParam);

        [DllImport("User32.dll")]
        private static extern Int32 SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        public const int WM_VSCROLL = 0x0115;
        public const int SB_BOTTOM = 7;
        public const int USER = 0x0400;

        private UsbCan usbIO;
        InnoMakerDevice currentDeivce;

        /// <summary>
        /// When Delayed Send, number send time
        /// </summary>

        UsbCan.innomaker_can can;

        private String[] bitrateIndexes = {
                                "20K","33.33K","40K","50K",
                                "66.66K","80K", "83.33K","100K",
                                "125K","200K", "250K","400K",
                                 "500K","666K","800K", "1000K"
                              };

        private String[] workModeInexes =
        {
            "Normal","LoopBack","Repeat"
        };

        private String[] frameFormatIndexes =
        {
           "Standard","Extended"
        };

        private String[] frameTypeIndexes =
        {
            "Data Frame","Remote Frame"
        };

        public struct My_lParam
        {
            public int i;
            public string s;
        }
       
        private ConcurrentQueue<Byte[]> recvBufQueue = new ConcurrentQueue<Byte[]>();
        private List<Byte[]> recBufList = new List<Byte[]>();

        public SpinLock recv_buf_lock;
        delegate void updateListViewDelegate(Byte[] inputBytes);
        delegate void updateSendBtnDelegate(int tag);
        delegate void updateListBoxDelegate(String str);

        public void Init()
        {
            usbIO = new UsbCan();

            can = new UsbCan.innomaker_can();
            can.tx_context = new UsbCan.innomaker_tx_context[UsbCan.innomaker_MAX_TX_URBS];
        }

        /// <summary>
        /// 
        /// </summary>

        public List<String> UpdateDevices()
        {
            /// Close current device 
            if (currentDeivce != null)
            {
                currentDeivce = null;
            }

            usbIO.scanInnoMakerDevices();

            List<String> devIndexes = new List<string>();
            for (int i = 0; i < usbIO.getInnoMakerDeviceCount(); i++)
            {
                InnoMakerDevice device = usbIO.getInnoMakerDevice(i);
                devIndexes.Add(device.deviceId);
            }

            return devIndexes;
        }

        /// <summary>
        /// 
        /// </summary>

        public bool Connect(uint canid, int index, bool extended)
        {
            if (index < 0) return false;

            CAN_ID = canid;
            CAN_EXT = extended;

            UsbCan.UsbCanMode usbCanMode = UsbCan.UsbCanMode.UsbCanModeNormal;

            currentDeivce = usbIO.getInnoMakerDevice(index);

            usbCanMode = UsbCan.UsbCanMode.UsbCanModeNormal;
           
            bool result = usbIO.UrbSetupDevice(currentDeivce, usbCanMode, m_Baudrate);

            if (!result) return false;

            /// Reset current device tx_context  
            for (int i = 0; i < UsbCan.innomaker_MAX_TX_URBS; i++)
            {
                can.tx_context[i] = new UsbCan.innomaker_tx_context();
                can.tx_context[i].echo_id = UsbCan.innomaker_MAX_TX_URBS;
            }

            bConnect = true;

            return true;
        }

        public void DisConnect()
        {
            /// Wait for recv timer process done, because recv time interval is 100
            Thread.Sleep(100);
            if (currentDeivce != null && currentDeivce.isOpen == true)
            {
                usbIO.UrbResetDevice(currentDeivce);
                usbIO.closeInnoMakerDevice(currentDeivce);
            }

            /// Reset current device tx_context
            for (int i = 0; i < UsbCan.innomaker_MAX_TX_URBS; i++)
            {
                can.tx_context[i] = new UsbCan.innomaker_tx_context();
                can.tx_context[i].echo_id = UsbCan.innomaker_MAX_TX_URBS;
            }

            bConnect = false;
        }

        /// <summary>
        /// 受信処理
        /// </summary>

        public void ReadMessages()
        {
            if (currentDeivce == null || currentDeivce.isOpen == false)
            {
                return;
            }

            UsbCan.innomaker_host_frame frame = new UsbCan.innomaker_host_frame();
            int size = Marshal.SizeOf(frame);
            Byte[] inputBytes = new Byte[size];

            int transferIn = 0;
            bool result = usbIO.asyncGetInnoMakerDeviceBuf(currentDeivce, inputBytes, size, transferIn, 10);

            if (result)
            {
                // Echo ID
                UInt32 echoId = BitConverter.ToUInt32(inputBytes, 0);

                /// Echo Frameの解放
                if (echoId != 0xffffffff)
                {
                    UsbCan.innomaker_tx_context txc = UsbCan.innomaker_get_tx_context(can, echoId);
                    
                    if (txc == null)
                    {
                        Console.WriteLine("RECV FAIL:Bad Devices Send Bad Echo_ids");
                        return;
                    }

                    /// Free 
                    UsbCan.innomaker_free_tx_context(txc);
                    return;
                }

                //Console.WriteLine("[recv] {0}byte -----------------", inputBytes.Length);
                //for (int i = 0; i < inputBytes.Length; i++) Console.WriteLine("recv[{0}] : {1:X2}", i, inputBytes[i]);

                ///受信パケット解析
                TPCANMsgFD newMsg = ReadParse(inputBytes);

                ///DeviceID
                newMsg.DEVICE = currentDeivce.deviceId;

                ///受信イベント
                m_ReceiveEvent(this, newMsg);
            }
        }

        private TPCANMsgFD ReadParse(Byte[] inputBytes)
        {
            TPCANMsgFD frame = new TPCANMsgFD();

            UInt32 frameId = BitConverter.ToUInt32(inputBytes, 4);

            frame.ID = frameId & 0x7FFFFFFF;
            frame.DLC = inputBytes[8];
            frame.DATA = new Byte[frame.DLC];
            frame.MSGTYPE = ((frameId & usbIO.Can_Eff_Flag) != 0x00) ? TPCANMessageType.PCAN_MESSAGE_EXTENDED : TPCANMessageType.PCAN_MESSAGE_STANDARD;

            Buffer.BlockCopy(inputBytes, 12, frame.DATA, 0, frame.DLC);

            return frame;
        }

        /// <summary>
        /// 送信処理
        /// </summary>

        public bool CmdFrame(byte[] srcBuff)
        {
            ///コマンドフラグをON
            bCommandFlag = true;

            return WriteFrame(srcBuff);
        }

        public bool WriteFrame(byte[] srcBuff)
        {
            if (!bConnect) return true;

            lock (LockWriteSequence)
            {
                UsbCan.innomaker_tx_context txc = UsbCan.innomaker_alloc_tx_context(can);
                if (txc.echo_id == 0xff)
                {
                    Console.WriteLine("SEND FAIL: NETDEV_BUSY");
                    return false;
                }

                Byte[] standardFrameData = buildStandardFrame(CAN_ID, srcBuff, CAN_LEN, txc.echo_id);
                int transferOut = 0;

                //Console.WriteLine("[send] {0}byte -----------------", standardFrameData.Length);
                //for (int i = 0; i < standardFrameData.Length; i++) Console.WriteLine("send[{0}] : {1:X2}", i, standardFrameData[i]);

                bool result = usbIO.syncSendInnoMakerDeviceBuf(currentDeivce, standardFrameData, standardFrameData.Length, 10, transferOut);
                if (result)
                {
                    //Console.WriteLine("SEND SUCCESS:" + getHexString(standardFrameData));
                    return true;
                }
                else
                {
                    Console.WriteLine("SEND FAIL");
                    UsbCan.innomaker_tx_context txc1 = UsbCan.innomaker_get_tx_context(can, txc.echo_id);
                    if (txc1 != null)
                    {
                        UsbCan.innomaker_free_tx_context(txc1);
                    }
                    return false;
                }
            }
        }

        public static String getHexString(byte[] b)
        {
            String hex = "0x|";
            for (int i = 0; i < b.Length; i++)
            {
                hex += (b[i] & 0xFF).ToString("X2");

                if (hex.Length == 1)
                {
                    hex = '0' + hex;
                }

                hex += " ";

            }

            return hex.ToUpper();

        }

        private Byte[] buildStandardFrame(uint canId, byte[] frameData, int framDlc, uint echoId)
        {
#if true
            UsbCan.innomaker_host_frame frame;

            frame.data = new Byte[CAN_LEN];
            frame.echo_id = echoId;
            frame.can_dlc = (byte)framDlc;
            frame.channel = 0;
            frame.flags = 0;
            frame.reserved = 0;
            frame.can_id = canId;

            if (CAN_EXT)
            {
                frame.can_id |= usbIO.Can_Eff_Flag;
            }

            for (int i = 0; i < framDlc; i++)
            {
                frame.data[i] = frameData[i];
            }

            frame.timestamp_us = 0;
#else
            /// Format frame id
            frameId = Formatter.formatStringToHex(frameId, 8, true);
            /// Format frame data
            frameData = Formatter.formatStringToHex(frameData, 16, true);
            /// Data Length
            int dlc = frameData.Split(' ').Length;

            UsbCan.innomaker_host_frame frame;

            frame.data = new Byte[8];
            frame.echo_id = echoId;
            frame.can_dlc = (byte)dlc;
            frame.channel = 0;
            frame.flags = 0;
            frame.reserved = 0;

            String[] canIdArr = frameId.Split(' ');
            Byte[] canId = { 0x00, 0x00, 0x00, 0x00 };
            for (int i = 0; i < canIdArr.Length; i++)
            {
                String b = canIdArr[canIdArr.Length - i - 1];
                canId[i] = (Byte)Convert.ToInt32(b, 16);

            }
            frame.can_id = System.BitConverter.ToUInt32(canId, 0);

            String[] dataByte = frameData.Split(' ');
            for (int i = 0; i < dataByte.Length; i++)
            {
                String byteValue = dataByte[i];

                frame.data[i] = (Byte)Convert.ToInt32(byteValue, 16);
            }

            frame.timestamp_us = 0;
#endif
            return StructureHelper.StructToBytes(frame);
        }

        ////////////////////////////////////////////////////////////////////////////////////////
        /// Inno Can Class
        ////////////////////////////////////////////////////////////////////////////////////////

        public class StructureHelper
        {
            public static byte[] StructToBytes(object structObj)
            {

                int size = Marshal.SizeOf(structObj);
                IntPtr buffer = Marshal.AllocHGlobal(size);
                try
                {
                    Marshal.StructureToPtr(structObj, buffer, false);
                    byte[] bytes = new byte[size];
                    Marshal.Copy(buffer, bytes, 0, size);
                    return bytes;
                }
                finally
                {
                    Marshal.FreeHGlobal(buffer);
                }
            }

            public static object ByteToStruct(byte[] bytes, Type type)
            {
                int size = Marshal.SizeOf(type);
                if (size > bytes.Length)
                {
                    return null;
                }

                IntPtr structPtr = Marshal.AllocHGlobal(size);
                Marshal.Copy(bytes, 0, structPtr, size);
                object obj = Marshal.PtrToStructure(structPtr, type);
                Marshal.FreeHGlobal(structPtr);
                return obj;
            }
        }

        public class Formatter
        {
            public static String formatString(String originString, String charactersInString)
            {
                String formatString = "";

                foreach (char c in originString)
                {
                    if (charactersInString.Contains(c.ToString()))
                    {
                        formatString += c;
                    }
                }

                return formatString;
            }

            private static String dealWithString(String str)
            {
                String dealStr = "";

                int i = 0;
                foreach (char c in str)
                {

                    if (++i == 3)
                    {
                        dealStr += " ";
                        i = 1;
                    }
                    dealStr += c.ToString();

                }
                return dealStr;
            }

            public static String formatStringToHex(String originString, int limitLength, bool padding)
            {

                if (padding)
                {
                    originString = originString.Replace(" ", "");
                }

                String str = formatString(originString, "0123456789ABCDEFabcdef");

                if (str.Length > limitLength)
                {
                    str = str.Substring(0, limitLength);

                }

                if (str.Length == 0)
                {
                    str = "00";
                }

                if (padding)
                {
                    str = dealWithString(str);
                }

                return str;
            }
        }

        /// <summary>
        /// 
        /// </summary>

        private UsbCan.innomaker_device_bittming m_Baudrate;

        public void cbbBaudrates_SelectedIndexChanged(int index)
        {
            UsbCan.innomaker_device_bittming bittming = new UsbCan.innomaker_device_bittming();

            switch (index)
            {
                case 0: /// 1000K
                    bittming.prop_seg = 5;
                    bittming.phase_seg1 = 6;
                    bittming.phase_seg2 = 4;
                    bittming.sjw = 1;
                    bittming.brp = 3;
                    break;
                case 1: /// 800K
                    bittming.prop_seg = 7;
                    bittming.phase_seg1 = 8;
                    bittming.phase_seg2 = 4;
                    bittming.sjw = 1;
                    bittming.brp = 3;
                    break;
                case 2: // 500K
                    bittming.prop_seg = 6;
                    bittming.phase_seg1 = 7;
                    bittming.phase_seg2 = 2;
                    bittming.sjw = 1;
                    bittming.brp = 6;
                    break;
                case 3: // 250K
                    bittming.prop_seg = 6;
                    bittming.phase_seg1 = 7;
                    bittming.phase_seg2 = 2;
                    bittming.sjw = 1;
                    bittming.brp = 12;
                    break;
                case 4: // 125K
                    bittming.prop_seg = 6;
                    bittming.phase_seg1 = 7;
                    bittming.phase_seg2 = 2;
                    bittming.sjw = 1;
                    bittming.brp = 24;
                    break;
                case 5: // 100K
                    bittming.prop_seg = 6;
                    bittming.phase_seg1 = 7;
                    bittming.phase_seg2 = 2;
                    bittming.sjw = 1;
                    bittming.brp = 30;
                    break;
                case 6: // 83.33K
                    bittming.prop_seg = 3;
                    bittming.phase_seg1 = 3;
                    bittming.phase_seg2 = 1;
                    bittming.sjw = 1;
                    bittming.brp = 72;
                    break;
                case 7: // 50K
                    bittming.prop_seg = 6;
                    bittming.phase_seg1 = 7;
                    bittming.phase_seg2 = 2;
                    bittming.sjw = 1;
                    bittming.brp = 60;
                    break;
                case 8: // 33.33K
                    bittming.prop_seg = 3;
                    bittming.phase_seg1 = 3;
                    bittming.phase_seg2 = 1;
                    bittming.sjw = 1;
                    bittming.brp = 180;
                    break;
                case 9: // 20K
                    bittming.prop_seg = 6;
                    bittming.phase_seg1 = 7;
                    bittming.phase_seg2 = 2;
                    bittming.sjw = 1;
                    bittming.brp = 150;
                    break;
                default: // 500K
                    bittming.prop_seg = 6;
                    bittming.phase_seg1 = 7;
                    bittming.phase_seg2 = 2;
                    bittming.sjw = 1;
                    bittming.brp = 6;
                    break;
            }

            m_Baudrate = bittming;
        }

    }
}
