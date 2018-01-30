using System;

namespace StrategyPattern
{
    /// <summary>
    /// 購物車
    /// </summary>
    public class ShoppingCart
    {
        /// <summary>
        /// 折扣
        /// </summary>
        private readonly IDiscount Discount;

        /// <summary>
        /// 商品總金額
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="discount">促銷活動折扣</param>
        public ShoppingCart(IDiscount discount)
        {
            Discount = discount;
        }

        /// <summary>
        /// 結帳
        /// </summary>
        public void CheckOut()
        {
            Console.WriteLine($"【{Discount.GetMarketingProgramName()}】商品總金額: {Amount} 總付款金額: {Discount.Calculate(Amount)}");
        }
    }
}