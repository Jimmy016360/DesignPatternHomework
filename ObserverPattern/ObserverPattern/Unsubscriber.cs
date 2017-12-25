using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    /// <summary>
    /// 提供者的 Subscribe 方法會傳回 IDisposable 實作，讓觀察者在呼叫 OnCompleted 方法之前停止接收通知
    /// </summary>
    /// <typeparam name="DateTime">目前通知資訊類型</typeparam>
    internal class Unsubscriber<DateTime> : IDisposable
    {
        /// <summary>
        /// 所有觀察者集合
        /// </summary>
        private List<IObserver<DateTime>> Observers;

        /// <summary>
        /// 當前觀察者
        /// </summary>
        private IObserver<DateTime> Observer;

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="observers">所有觀察者集合</param>
        /// <param name="observer">當前觀察者</param>
        internal Unsubscriber(List<IObserver<DateTime>> observers, IObserver<DateTime> observer)
        {
            this.Observers = observers;
            this.Observer = observer;
        }

        /// <summary>
        /// 查觀察者是否仍存在於 observers 集合中；如果存在的話，則會移除觀察者
        /// </summary>
        public void Dispose()
        {
            if (Observers.Contains(Observer))
                Observers.Remove(Observer);
        }
    }
}