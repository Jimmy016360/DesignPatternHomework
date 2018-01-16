using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    /// <summary>
    /// 中國信託信用卡驗證
    /// </summary>
    public class ChinaTrustValidator : ICreditCardValidator
    {
        /// <summary>
        /// 是否為有效的信用卡卡號
        /// </summary>
        /// <param name="creditCardNumber">信用卡卡號</param>
        /// <returns>有效/無效</returns>
        public bool IsValid(string creditCardNumber)
        {
            return true;
        }
    }
}
