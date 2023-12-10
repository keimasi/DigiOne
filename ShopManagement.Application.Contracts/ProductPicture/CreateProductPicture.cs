using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using _0_Framwork.Application;
using Microsoft.AspNetCore.Http;
using ShopManagement.Application.Contracts.Product;

namespace ShopManagement.Application.Contracts.ProductPicture
{
    public class CreateProductPicture
    {
        [FileSize(3,ErrorMessage = ValidationMessage.MaxFileSize)]
        public IFormFile Picture { get; set; }

        [Required(ErrorMessage = ValidationMessage.IsRequired)]
        public string PictureAlt { get; set; }

        [Required(ErrorMessage = ValidationMessage.IsRequired)]
        public string PictureTitle { get; set; }

        [Range(1,1000,ErrorMessage = ValidationMessage.IsRequired)]
        public int ProductId { get; set; }
        public List<ProductViewModel> Products { get; set; }
    }
}
