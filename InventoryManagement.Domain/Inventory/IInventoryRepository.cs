using System.Collections.Generic;
using _0_Framwork.Domain;
using InventoryManagement.Application.Contracts.Inventory;

namespace InventoryManagement.Domain.Inventory
{
    public interface IInventoryRepository : IRepository<int, InventoryEntity>
    {
        EditInventory GetDetails(int id);
        List<InventoryViewModel> GetInventories();
        InventoryEntity GetBy(int productId);
    }
}
