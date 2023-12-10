using System.ComponentModel.DataAnnotations;
using _0_Framwork.Application;
using Microsoft.AspNetCore.Http;

namespace ShopManagement.Application.Contracts.Slider
{
    public class CreateSlider
    {
        [FileSize(3,ErrorMessage = ValidationMessage.MaxFileSize)]
        public IFormFile Picture { get; set; }

        [Required(ErrorMessage = ValidationMessage.IsRequired)]
        public string PictureAlt { get; set; }

        [Required(ErrorMessage = ValidationMessage.IsRequired)]
        public string PictureTitle { get; set; }

        [Required(ErrorMessage = ValidationMessage.IsRequired)]
        public string Description { get; set; }
        public string Link { get; set; }
    }
}
