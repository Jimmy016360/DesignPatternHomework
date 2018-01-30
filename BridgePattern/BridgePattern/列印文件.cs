using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    /// <summary>
    /// 列印文件
    /// </summary>
    public class 列印文件
    {
        /// <summary>
        /// 列印文件實作
        /// </summary>
        private readonly 列印文件實作 實作;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="實作">列印文件實作</param>
        public 列印文件(列印文件實作 實作)
        {
            this.實作 = 實作;
        }

        /// <summary>
        /// 列印
        /// </summary>
        public void 列印()
        {
            實作.列印();
        }

        /// <summary>
        /// 開啟
        /// </summary>
        public void 開啟()
        {
            實作.開啟();
        }

        /// <summary>
        /// 關閉
        /// </summary>
        public void 關閉()
        {
            實作.關閉();
        }

        /// <summary>
        /// 顯示
        /// </summary>
        public void 顯示()
        {
            開啟();
            列印();
            關閉();
        }
    }
}
