using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // 第一家組裝店
            IComputerStore senaoStore = new SenaoComputerStore();

            // 第二家組裝店
            IComputerStore oanesStore = new OanesComputerStore();

            // 兩家組出來的電腦
            CustomComputer senaoComputer = senaoStore.CustomBuild();
            CustomComputer oanesComputer = oanesStore.CustomBuild();

            // 顯示兩家組出來的電腦規格
            senaoComputer.Display();
            oanesComputer.Display();

            Console.ReadKey();
        }
    }
}
