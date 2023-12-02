namespace ShopManagement.Application.Contracts.Product
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Picture { get; set; }
        public string CategoryName { get; set; }
        public string CreateDate { get; set; }
    }
}