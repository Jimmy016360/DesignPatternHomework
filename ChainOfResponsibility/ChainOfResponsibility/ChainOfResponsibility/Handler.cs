using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    /// <summary>
    /// The 'Handler' abstract class
    /// </summary>
    public abstract class Handler
    {
        /// <summary>
        /// 驗證成功後下一個驗證
        /// </summary>
        protected Handler successor;

        /// <summary>
        /// 設定下一個驗證
        /// </summary>
        /// <param name="successor">下一個驗證</param>
        public void SetSuccessor(Handler successor)
        {
            this.successor = successor;
        }

        /// <summary>
        /// 驗證處理
        /// </summary>
        /// <param name="request">驗證目標</param>
        /// <returns>驗證成功與否</returns>
        public abstract bool HandleRequest(string request);
    }
}