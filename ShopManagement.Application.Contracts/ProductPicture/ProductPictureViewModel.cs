namespace ShopManagement.Application.Contracts.ProductPicture
{
    public class ProductPictureViewModel
    {
        public int Id { get; set; }
        public string Product { get; set; }
        public string Picture { get; set; }
        public string CreateDate { get; set; }
        public bool IsRemoved { get; set; }
    }
}