using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // 全部打八折活動
            TwentyPercentOff twentyPercent  = new TwentyPercentOff();

            // 買千折百活動
            RebatePurchaseOverThousand rebate = new RebatePurchaseOverThousand();

            // 第1個顧客購物車，商品總金額5000，使用全部打八折活動
            ShoppingCart customer1 = new ShoppingCart(twentyPercent)
            {
                Amount = 5000
            };
            customer1.CheckOut();

            // 第2個顧客購物車，商品總金額1200，使用買千折百活動
            ShoppingCart customer2 = new ShoppingCart(rebate)
            {
                Amount = 1200
            };
            customer2.CheckOut();

            // 第3個顧客購物車，商品總金額780，使用買千折百活動
            ShoppingCart customer3 = new ShoppingCart(rebate)
            {
                Amount = 780
            };
            customer3.CheckOut();

            Console.ReadKey();
        }
    }
}
