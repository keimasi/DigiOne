namespace ShopManagement.Application.Contracts.Order
{
    public class CartItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Picture { get; set; }
        public int Count { get; set; }
        public double TotalItemPrice { get; set; } //جمع همه آیتم ها بدون محاسبه تخفیف
        public bool IsInStock { get; set; }
        public int DiscountRate { get; set; } //درصد تخفیف
        public double ItemPayAmount { get; set; } // مبلغ نهایی با محاسبه تخفیف
    }
}
