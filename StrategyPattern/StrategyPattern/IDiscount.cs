using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    /// <summary>
    /// 行銷折扣介面
    /// </summary>
    public interface IDiscount
    {
        /// <summary>
        /// 取得行銷折扣名稱
        /// </summary>
        /// <returns>行銷折扣名稱</returns>
        string GetMarketingProgramName();

        /// <summary>
        /// 折扣計算
        /// </summary>
        /// <param name="amount">總金額</param>
        /// <returns>折扣後金額</returns>
        int Calculate(int amount);
    }
}
