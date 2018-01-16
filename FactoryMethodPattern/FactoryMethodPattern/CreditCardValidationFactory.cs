using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    /// <summary>
    /// 信用卡授權工廠
    /// </summary>
    public static class CreditCardValidationFactory
    {
        /// <summary>
        /// 信用卡授權字典
        /// </summary>
        private static Dictionary<CreditCardIssuerEnum, ICreditCardValidator> Validators =
            new Dictionary<CreditCardIssuerEnum, ICreditCardValidator>
            {
                {CreditCardIssuerEnum.CathayUnitedBank, new CathayValidator()},
                {CreditCardIssuerEnum.ChinaTrustBank, new ChinaTrustValidator()},
                {CreditCardIssuerEnum.Nccc, new NcccValidator()}
            };

        /// <summary>
        /// 取得相對應的信用卡授權機構
        /// </summary>
        /// <param name="issuer">發卡行</param>
        /// <returns>信用卡授權</returns>
        public static ICreditCardValidator Validator(CreditCardIssuerEnum issuer)
        {
            return Validators[issuer];
        }
    }
}
