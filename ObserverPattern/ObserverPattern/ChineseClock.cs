using System;

namespace ObserverPattern
{
    /// <summary>
    /// 數位時鐘
    /// </summary>
    public class ChineseClock : IObserver<DateTime>
    {
        /// <summary>
        /// 取消訂閱
        /// </summary>
        private IDisposable cancellation;

        /// <summary>
        /// 訂閱
        /// </summary>
        /// <param name="provider">欲訂閱的目標時間處理器</param>
        public void Subscribe(ClockHandler provider)
        {
            cancellation = provider.Subscribe(this);
        }

        /// <summary>
        /// 取消訂閱
        /// </summary>
        public void Unsubscribe()
        {
            cancellation.Dispose();
        }

        /// <summary>
        /// 提供新的資料給觀察器
        /// </summary>
        /// <param name="value">目前通知資訊</param>
        public void OnNext(DateTime value)
        {
            Console.WriteLine($"現在時間:{value.Hour}時 {value.Minute}分 {value.Second}秒");
        }

        /// <summary>
        /// 向觀察器告知提供者已發生錯誤狀況。
        /// </summary>
        /// <param name="error">物件，提供錯誤的其他相關資訊。</param>
        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 向觀察器告知提供者已完成推入型通知的傳送。
        /// </summary>
        public void OnCompleted()
        {
            throw new NotImplementedException();
        }
    }
}