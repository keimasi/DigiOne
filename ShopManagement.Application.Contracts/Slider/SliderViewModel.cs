namespace ShopManagement.Application.Contracts.Slider
{
    public class SliderViewModel
    {
        public int Id { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public bool IsRemove { get; set; }
        public string CreateDate { get; set; }
    }
}