using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    /// <summary>
    /// 身分證編碼規則驗證
    /// </summary>
    public class RuleHandler : Handler
    {
        public override bool HandleRequest(string request)
        {
            if (IsValid(request))
            {
                return successor?.HandleRequest(request) ?? true;
            }
            return false;
        }

        /// <summary>
        /// 是否為合格的編號
        /// </summary>
        /// <param name="request">驗證目標</param>
        /// <returns>合格與否</returns>
        private bool IsValid(string request)
        {
            var a = new[] { 10, 11, 12, 13, 14, 15, 16, 17, 34, 18, 19, 20, 21, 22, 35, 23, 24, 25, 26, 27, 28, 29, 32, 30, 31, 33 };
            var b = new int[11];
            b[1] = a[(request[0]) - 65] % 10;
            var c = b[0] = a[(request[0]) - 65] / 10;
            for (var i = 1; i <= 9; i++)
            {
                b[i + 1] = request[i] - 48;
                c += b[i] * (10 - i);
            }
            if (((c % 10) + b[10]) % 10 == 0)
            {
                return true;
            }

            return false;
        }
    }
}