using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ClockHandler provider = new ClockHandler();
            DigitalClock digitalClock = new DigitalClock();
            digitalClock.Subscribe(provider);

            while (true)
            {
                provider.OnClick();
                Thread.Sleep(1000);
            }
        }
    }
}
