using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using _0_Framwork.Application;
using ShopManagement.Application.Contracts.Product;

namespace InventoryManagement.Application.Contracts.Inventory
{
    public class CreateInventory
    {
        [Range(1,1000,ErrorMessage = ValidationMessage.IsRequired)]
        public int ProductId { get; set; }

        [Range(1,double.MaxValue,ErrorMessage = ValidationMessage.IsRequired)]
        public double UnitPrice { get; set; }

        public List<ProductViewModel> Product { get; set; }
    }
}
