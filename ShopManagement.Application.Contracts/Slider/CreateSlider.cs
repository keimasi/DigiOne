using System.ComponentModel.DataAnnotations;
using _0_Framwork.Application;

namespace ShopManagement.Application.Contracts.Slider
{
    public class CreateSlider
    {
        [Required(ErrorMessage = ValidationMessage.IsRequired)]
        public string Picture { get; set; }

        [Required(ErrorMessage = ValidationMessage.IsRequired)]
        public string PictureAlt { get; set; }

        [Required(ErrorMessage = ValidationMessage.IsRequired)]
        public string PictureTitle { get; set; }

        [Required(ErrorMessage = ValidationMessage.IsRequired)]
        public string Description { get; set; }
        public string Link { get; set; }
    }
}
