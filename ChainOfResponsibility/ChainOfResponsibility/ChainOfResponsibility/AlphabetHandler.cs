using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    /// <summary>
    /// 字首字母驗證
    /// </summary>
    public class AlphabetHandler : Handler
    {
        public override bool HandleRequest(string request)
        {
            request = request.ToUpper();
            if (request[0] >= 0x41 && request[0] <= 0x5A)
            {
                return successor?.HandleRequest(request) ?? true;
            }
            return false;
        }
    }
}