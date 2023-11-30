using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using _0_Framwork.Application;
using ShopManagement.Application.Contracts.Product;

namespace DiscountManagement.Application.Contracts.CustomerDiscount
{
    public class CreateCustomerDiscount
    {
        [Range(1,100,ErrorMessage = ValidationMessage.IsRequired)]
        public int DiscountRate { get; set; }

        [Required(ErrorMessage = ValidationMessage.IsRequired)]
        public string StartDate { get; set; }

        [Required(ErrorMessage = ValidationMessage.IsRequired)]
        public string EndDate { get; set; }

        public string Description { get; set; }

        [Range(1,1000,ErrorMessage = ValidationMessage.IsRequired)]
        public int ProductId { get; set; }

        public List<ProductViewModel> Product { get; set; }
    }
}
