using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP
{
    /// <summary>
    /// USB-CANのインターフェース関数定義
    /// </summary>

    public interface ClassCanUsb
    {
        /// <summary>
        /// 接続
        /// </summary>

        bool Connect(uint canid, int index, bool extended);

        /// <summary>
        /// 切断
        /// </summary>

        void DisConnect();

        /// <summary>
        /// 初期化
        /// </summary>

        void Init();

        /// <summary>
        /// 接続中の確認関数
        /// </summary>

        bool IsConnect();

        /// <summary>
        /// コマンドモードの確認関数
        /// </summary>

        bool IsCommandMode();

        /// <summary>
        /// コマンドモード解除
        /// </summary>

        void ClearCommandMode();

        /// <summary>
        /// パケット受信
        /// </summary>

        void ReadMessages();

        /// <summary>
        /// パケット送信(コマンドパケット)
        /// </summary>

        bool CmdFrame(byte[] srcBuff);

        /// <summary>
        /// パケット送信(通常パケット)
        /// </summary>

        bool WriteFrame(byte[] srcBuff);

        /// <summary>
        /// デバイススキャン
        /// </summary>

        List<String> UpdateDevices();

        /// <summary>
        /// ボーレート変更イベント
        /// </summary>

        void cbbBaudrates_SelectedIndexChanged(int index);

        /// <summary>
        /// パケット受信イベント
        /// </summary>

        event EventHandler<TPCANMsgFD> m_ReceiveEvent;
    }
}
