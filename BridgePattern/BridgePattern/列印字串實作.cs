using System;
using System.Linq;

namespace BridgePattern
{
    public class 列印字串實作 : 列印文件實作
    {
        /// <summary>
        /// 欲列印的字串
        /// </summary>
        private readonly string 字串;

        /// <summary>
        /// 字串寬度
        /// </summary>
        private readonly int 寬度;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="字串">欲列印的字串</param>
        public 列印字串實作(string 字串)
        {
            this.字串 = 字串;
            this.寬度 = 字串.Length;
        }

        /// <summary>
        /// 列印
        /// </summary>
        public override void 列印()
        {
            Console.WriteLine("|" + this.字串 + "|");
        }

        /// <summary>
        /// 開啟
        /// </summary>
        public override void 開啟()
        {
            this.列印分隔線();
        }

        /// <summary>
        /// 關閉
        /// </summary>
        public override void 關閉()
        {
            this.列印分隔線();
        }

        /// <summary>
        /// 列印分隔線
        /// </summary>
        private void 列印分隔線()
        {
            Console.Write("+");
            Console.Write(string.Concat(Enumerable.Repeat("-", this.寬度)));
            Console.WriteLine("+");
        }
    }
}
