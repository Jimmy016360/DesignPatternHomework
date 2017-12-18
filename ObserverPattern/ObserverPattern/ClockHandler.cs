using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    /// <summary>
    /// 時間處理器
    /// </summary>
    public class ClockHandler : IObservable<DateTime>
    {
        /// <summary>
        /// 目前訂閱的時鐘
        /// </summary>
        private List<IObserver<DateTime>> observers;

        /// <summary>
        /// 建構子
        /// </summary>
        public ClockHandler()
        {
            observers = new List<IObserver<DateTime>>();
        }

        /// <summary>
        /// 訂閱
        /// </summary>
        /// <param name="observer">欲訂閱的時鐘</param>
        /// <returns>取消訂閱</returns>
        public IDisposable Subscribe(IObserver<DateTime> observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }
            
            return new Unsubscriber<DateTime>(observers,observer);
        }

        /// <summary>
        /// 時間觸發，同時通知訂閱的時鐘
        /// </summary>
        public void OnClick()
        {
            foreach (var observer in observers)
            {
                observer.OnNext(DateTime.Now);
            }
        }
    }
}
