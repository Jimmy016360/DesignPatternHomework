using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    /// <summary>
    /// 總金額八折
    /// </summary>
    public class TwentyPercentOff : IDiscount
    {
        /// <summary>
        /// 取得行銷折扣名稱
        /// </summary>
        /// <returns>行銷折扣名稱</returns>
        public string GetMarketingProgramName()
        {
            return "總金額八折";
        }

        /// <summary>
        /// 折扣計算
        /// </summary>
        /// <param name="amount">總金額</param>
        /// <returns>折扣後金額</returns>
        public int Calculate(int amount)
        {
            return (int)Math.Ceiling(amount * 0.8);
        }
    }
}
