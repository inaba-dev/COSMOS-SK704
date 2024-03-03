using System;
using System.Collections.Generic;
using System.Linq;

namespace APP
{
    public static class Func
    {
        /// <summary>
        /// シーケンス番号
        /// </summary>

        public static double ConvSequNumber(int data)
        {
            return Convert.ToDouble(data);
        }

        /// <summary>
        /// Gas concentration
        /// </summary>

        public static int ConvGas1(int data)
        {
            return (data - 10) * 500;
        }

        public static int ConvGas2(int data)
        {
            return (data) * 200;
        }

        /// <summary>
        /// 温度
        /// </summary>

        public static double ConvTemperatureLeakage(int data)
        {
            return Math.Round(Convert.ToDouble(data) * 0.05 + (-50.0), 2);
        }

        public static double ConvTemperatureExhaust(int data)
        {
            return Math.Round(Convert.ToDouble(data) * 0.00335684 + (-60.0), 2);
        }

        /// <summary>
        /// 湿度
        /// </summary>

        public static double ConvHumidity(int data)
        {
            return Math.Round(Convert.ToDouble(data) * 0.4, 2);
        }

        /// <summary>
        /// 
        /// </summary>

        public static int int2asc(int src)
        {
            if (src < 10) return (src + 0x30);
            else if (src < 16) return ((src - 10) + 0x41);
            else return 0;
        }

        public static int asc2int(int src)
        {
            if (src > 0x40) return (src - 0x41 + 10);
            else if (src >= 0x30) return (src - 0x30);
            else return 0;
        }
    }
}
