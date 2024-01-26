namespace ShopManagement.Application.Contracts.Order
{
    public class OrderItemViewModel
    {
        public string ProductName { get; set; }
        public int Count { get; set; }
        public string UnitPrice { get; set; }
        public int DiscountRate { get; set; }
    }
}
