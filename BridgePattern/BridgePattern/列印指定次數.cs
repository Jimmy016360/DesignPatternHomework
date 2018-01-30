using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    /// <summary>
    /// 列印指定次數
    /// </summary>
    public class 列印指定次數 : 列印文件
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="實作">列印文件實作</param>
        public 列印指定次數(列印文件實作 實作) : base(實作)
        {
        }

        /// <summary>
        /// 反覆列印
        /// </summary>
        /// <param name="times">重複列印次數</param>
        public void 反覆列印(int times)
        {
            this.開啟();
            for (int i = 0; i < times; i++)
            {
                this.列印();
            }
            this.關閉();
        }
    }
}
