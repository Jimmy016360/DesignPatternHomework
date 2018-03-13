using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    /// <summary>
    /// 長度為10驗證
    /// </summary>
    public class LengthHandler : Handler
    {
        public override bool HandleRequest(string request)
        {
            if (request.Length == 10)
            {
                return successor?.HandleRequest(request) ?? true;
            }
            return false;
        }
    }
}