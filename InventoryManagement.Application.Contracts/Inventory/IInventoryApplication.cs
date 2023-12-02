using System.Collections.Generic;
using _0_Framwork.Application;

namespace InventoryManagement.Application.Contracts.Inventory
{
    public interface IInventoryApplication
    {
        OperationResult Create(CreateInventory command);
        OperationResult Edit(EditInventory command);
        EditInventory GetDetails(int Id);
        List<InventoryViewModel> GetInventories();

        OperationResult Increase(IncreaseInventory command);
        OperationResult Decrease(List<DecreaseInventory> command);
        OperationResult Decrease(DecreaseInventory command);

        List<InventoryOperationViewModel> GetInventoryOperationLog(int inventoryId);
    }
}
