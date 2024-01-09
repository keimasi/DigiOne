namespace ShopManagement.Application.Contracts.Order
{
    public class CartItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Picture { get; set; }
        public int Count { get; set; }
        public double TotalItemPrice { get; set; }
        public bool IsInStock { get; set; }
    }
}
