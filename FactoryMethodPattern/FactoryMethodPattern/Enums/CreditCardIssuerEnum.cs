using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    /// <summary>
    /// 信用卡發卡行
    /// </summary>
    public enum CreditCardIssuerEnum
    {
        /// <summary>
        /// 國泰
        /// </summary>
        CathayUnitedBank = 0,

        /// <summary>
        /// 中信
        /// </summary>
        ChinaTrustBank = 1,

        /// <summary>
        /// NCCC
        /// </summary>
        Nccc
    }
}
