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
    public class 列印隨機次數 : 列印文件
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="實作">列印文件實作</param>
        public 列印隨機次數(列印文件實作 實作) : base(實作)
        {
        }

        /// <summary>
        /// 隨機列印
        /// </summary>
        public void 隨機列印()
        {
            // 取得隨機數值
            Random random = new Random(DateTime.Now.Second);
            int randomNumber = random.Next(100);
            
            this.開啟();
            for (int i = 0; i < randomNumber; i++)
            {
                this.列印();
            }
            this.關閉();
        }
    }
}
