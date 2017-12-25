using System;
using System.Threading;

namespace ObserverPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // 每秒鐘觸發的事件主題
            TickEverySecondClockHandler secondProvider = new TickEverySecondClockHandler();

            // 每分鐘觸發的事件主題
            TickEveryMinClockHandler minProvider = new TickEveryMinClockHandler();

            // 數位時鐘訂閱者
            DigitalClock digitalClock = new DigitalClock();

            // 中文時鐘訂閱者
            ChineseClock chineseClock = new ChineseClock();

            // 數位時鐘訂閱的每秒和每分的事件主題
            digitalClock.Subscribe(secondProvider);
            digitalClock.Subscribe(minProvider);

            // 中文時鐘訂閱每分的事件主題
            chineseClock.Subscribe(minProvider);

            // 事件觸發模擬
            while (true)
            {
                // 每秒鐘觸發一次
                secondProvider.OnClick();

                // 每十秒觸發一次
                if (DateTime.Now.Second == 0)
                {
                    minProvider.OnClick();
                }

                Thread.Sleep(1000);
            }
        }
    }
}