using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    /// <summary>
    /// 時間處理器抽象類別
    /// </summary>
    public abstract class ClockHandler : IObservable<DateTime>
    {
        /// <summary>
        /// 目前訂閱的時鐘
        /// </summary>
        protected List<IObserver<DateTime>> observers = new List<IObserver<DateTime>>();

        /// <summary>
        /// 訂閱
        /// </summary>
        /// <param name="observer">欲訂閱的時鐘</param>
        /// <returns>取消訂閱</returns>
        public virtual IDisposable Subscribe(IObserver<DateTime> observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }

            return new Unsubscriber<DateTime>(observers, observer);
        }

        /// <summary>
        /// 時間觸發，同時通知訂閱的時鐘
        /// </summary>
        public virtual void OnClick()
        {
            foreach (var observer in observers)
            {
                observer.OnNext(DateTime.Now);
            }
        }
    }
}