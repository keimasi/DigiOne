namespace _01_DigiOneQuery.Contracts.Product
{
    public class ProductPictureQueryModel
    {
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public int ProductId { get; set; }
        public bool IsRemove { get; set; }
    }
}