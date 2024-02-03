using _01_DigiOneQuery.Contracts.Inventory;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Presentation.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryQuery _inventoryQuery;

        public InventoryController(IInventoryQuery inventoryQuery)
        {
            _inventoryQuery = inventoryQuery;
        }

        [HttpPost]
        public StockStatus CheckStock(IsInStock command)
        {
            return _inventoryQuery.CheckStock(command);
        }
    }
}
