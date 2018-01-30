using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            列印文件 列印內容1 = new 列印文件(new 列印字串實作(" Hello World!"));
            列印內容1.顯示();

            列印文件 列印內容2 = new 列印指定次數(new 列印字串實作(" Hello Taiwan!"));
            列印內容2.顯示();

            列印指定次數 列印內容3 = new 列印指定次數(new 列印字串實作(" Hello Taiwan!"));
            列印內容3.反覆列印(10);

            列印指定次數 列印內容4 = new 列印指定次數(new 列印檔案實作(" Hello Taiwan!"));
            列印內容4.反覆列印(10);

            列印隨機次數 列印內容5 = new 列印隨機次數(new 列印檔案實作(" Hello Taiwan!"));
            列印內容5.隨機列印();


            Console.ReadKey();
        }
    }
}
