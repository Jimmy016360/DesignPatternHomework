using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    /// <summary>
    /// 組裝電腦
    /// </summary>
    public class CustomComputer
    {
        /// <summary>
        /// 電腦零件清單
        /// </summary>
        private readonly List<string> Parts = new List<string>();

        /// <summary>
        /// 增加電腦零件
        /// </summary>
        /// <param name="part"></param>
        public void AddPart(string part)
        {
            Parts.Add(part);
        }

        /// <summary>
        /// 列出電腦零件
        /// </summary>
        public void Display()
        {
            Console.WriteLine("======= 電腦零件 =======");
            Parts.ForEach(Console.WriteLine);
        }
    }
}
