using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    /// <summary>
    /// 列印文件實作
    /// </summary>
    public abstract class 列印文件實作
    {
        /// <summary>
        /// 列印
        /// </summary>
        public abstract void 列印();

        /// <summary>
        /// 開啟
        /// </summary>
        public abstract void 開啟();

        /// <summary>
        /// 關閉
        /// </summary>
        public abstract void 關閉();
    }
}
