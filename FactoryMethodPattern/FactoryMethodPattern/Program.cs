using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string creditCardNumber = "4539 0685 4366 1747";
            ICreditCardValidator validator = CreditCardValidationFactory.Validator(CreditCardIssuerEnum.Nccc);
            string validationResult = validator.IsValid(creditCardNumber) ? "有效" : "無效";
            Console.WriteLine($"信用卡卡號[{creditCardNumber}] 是{validationResult}的");
            Console.ReadKey();
        }
    }
}
