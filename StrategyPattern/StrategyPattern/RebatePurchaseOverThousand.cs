using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    /// <summary>
    /// 買千折百
    /// </summary>
    public class RebatePurchaseOverThousand : IDiscount
    {
        /// <summary>
        /// 取得行銷折扣名稱
        /// </summary>
        /// <returns>行銷折扣名稱</returns>
        public string GetMarketingProgramName()
        {
            return "買千折百";
        }

        /// <summary>
        /// 折扣計算
        /// </summary>
        /// <param name="amount">總金額</param>
        /// <returns>折扣後金額</returns>
        public int Calculate(int amount)
        {
            return amount >= 1000 ? amount - 100 : amount;
        }
    }
}
