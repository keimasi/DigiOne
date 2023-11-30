using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using _0_Framwork.Application;
using ShopManagement.Application.Contracts.Product;

namespace DiscountManagement.Application.Contracts.ColleagueDiscount
{
    public class CreateColleagueDiscount
    {
        [Range(1,100,ErrorMessage = ValidationMessage.IsRequired)]
        public int DiscountRate { get; set; }

        [Range(1,1000,ErrorMessage = ValidationMessage.IsRequired)]
        public int ProductId { get; set; }

        public List<ProductViewModel> Product { get; set; }
    }
}
