namespace _01_DigiOneQuery.Contracts.Product
{
    public class ProductQueryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public string Slug { get; set; }
        public string PriceAfterDiscount { get; set; }
        public int DiscountRate { get; set; }
        public string DiscountExpireDate { get; set; }
        public bool HasDiscount { get; set; }
    }
}
