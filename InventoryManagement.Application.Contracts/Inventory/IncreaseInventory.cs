using System.ComponentModel.DataAnnotations;
using _0_Framwork.Application;

namespace InventoryManagement.Application.Contracts.Inventory
{
    public class IncreaseInventory
    {
        public int InventoryId { get; set; }

        [Range(1,int.MaxValue,ErrorMessage = ValidationMessage.IsRequired)]
        public int Count { get; set; }

        [Required(ErrorMessage = ValidationMessage.IsRequired)]
        public string Description { get; set; }
    }
}
