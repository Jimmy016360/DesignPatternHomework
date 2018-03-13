using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var alphabetHandler = new AlphabetHandler();
            var lengthHandler = new LengthHandler();
            var ruleHandler = new RuleHandler();
            alphabetHandler.SetSuccessor(lengthHandler);
            lengthHandler.SetSuccessor(ruleHandler);

            // 驗證
            var data = new string[] { "A123456789", "A1234", "G193839141", "987654321", "ABC1235678", "A104376113" };
            foreach (var d in data)
            {
                var result = alphabetHandler.HandleRequest(d);

                Console.WriteLine($"{d} is {result}");
            }

            Console.ReadKey();
        }
    }
}