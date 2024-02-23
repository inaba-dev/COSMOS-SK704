using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP
{
    public static class Define
    {
        /// <summary>
        /// 全般設定
        /// <summary>

        public enum StatusResponse : int
        {
            FatalError = -1, // 致命的なエラー(強制終了)
            Failure = 0,     // 失敗
            Success = 1      // 成功
        };

        public enum FileResponse : int
        {
            FatalError = 0,
            OpenError = -1,
            Success = 1
        };

        public const bool Enable = true;
        public const bool Disable = false;

        public const bool Inno = true;
        public const bool Peak = false;

        /// <summary>
        /// パラメータ設定
        /// <summary>

        public static readonly uint CMD_PACKET_TYPE_STD_ID = 0x0202; // コマンド送受信のCAN-ID(STD)
        //public static readonly uint CMD_PACKET_TYPE_STD_ID = 0x0600; // コマンド送受信のCAN-ID(STD)
        public static readonly uint CMD_PACKET_TYPE_EXT_ID = 0xF600; // コマンド送受信のCAN-ID(EXT)

        public static readonly string[] defErrorFlag = new string[] {
            "センサエラー",
            "濃度エラー",
            "データフラッシュエラー",
            "スパン調整エラー",
            "ゼロ調整エラー",
            "回路故障エラー",
            "温度エラー",
            "電源電圧エラー",
        };

        public static readonly string[] defStatusFlag = new string[] {
            "マイナス濃度",
            "濃度情報有効(暖気完了など)",
            "濃度潜り補正中",
            "AD種別 センサ中間電圧",
            "AD種別 センサ出力",
            "AD種別 温度サーミスタ",
            "AD種別 電源電圧"
        };

        /// <summary>
        /// フォルダ設定
        /// <summary>

        public static readonly string defAppFolder = Directory.GetCurrentDirectory();

        //
        public static readonly string defConfigFile = Define.defAppFolder + @"\" + "config.xml";
    }
}
