using System.Collections.Generic;
using _0_Framwork.Application;
using InventoryManagement.Application.Contracts.Inventory;
using InventoryManagement.Domain.Inventory;

namespace InventoryManagement.Application
{
    public class InventoryApplication:IInventoryApplication
    {
        private readonly IInventoryRepository _inventoryRepository;

        public InventoryApplication(IInventoryRepository inventoryRepository)
        {
            _inventoryRepository = inventoryRepository;
        }

        public OperationResult Create(CreateInventory command)
        {
            var operation=new OperationResult();
            if (_inventoryRepository.Exists(x => x.ProductId == command.ProductId))
                return operation.Failed(ApplicationMessage.DuplicatedRecord);

            var inventory = new InventoryEntity(command.ProductId, command.UnitPrice);
            _inventoryRepository.Create(inventory);
            _inventoryRepository.Save();
            return operation.Success();
        }

        public OperationResult Edit(EditInventory command)
        {
            var operation=new OperationResult();
            var inventory = _inventoryRepository.Get(command.Id);
            if (inventory == null)
                return operation.Failed(ApplicationMessage.RecordNotFound);

            if (_inventoryRepository.Exists(x => x.ProductId == command.ProductId && x.Id != command.Id))
                return operation.Failed(ApplicationMessage.DuplicatedRecord);

            inventory.Edit(command.ProductId,command.UnitPrice);
            _inventoryRepository.Save();
            return operation.Success();
        }

        public EditInventory GetDetails(int Id)
        {
            return _inventoryRepository.GetDetails(Id);
        }

        public List<InventoryViewModel> GetInventories()
        {
            return _inventoryRepository.GetInventories();
        }

        public OperationResult Increase(IncreaseInventory command)
        {
            var operation=new OperationResult();
            var inventory = _inventoryRepository.Get(command.InventoryId);
            if (inventory == null)
                return operation.Failed(ApplicationMessage.RecordNotFound);

            int operatorId = 1;
            inventory.Increase(operatorId,command.Count,command.Description);
            _inventoryRepository.Save();
            return operation.Success();
        }

        public OperationResult Decrease(List<DecreaseInventory> command)
        {
            var operation=new OperationResult();
            int operatorId = 1;

            foreach (var item in command)
            {
                var inventory = _inventoryRepository.GetBy(item.ProductId);
                inventory.Decrease(operatorId,item.Count,item.Description,item.OrderId);
            }
            _inventoryRepository.Save();
            return operation.Success();
        }

        public OperationResult Decrease(DecreaseInventory command)
        {
            var operation=new OperationResult();
            var inventory = _inventoryRepository.Get(command.InventoryId);
            if (inventory == null)
                return operation.Failed(ApplicationMessage.RecordNotFound);

            int operatorId = 1;
            inventory.Decrease(operatorId,command.Count,command.Description,0);
            _inventoryRepository.Save();
            return operation.Success();
        }
    }
}
