using System;

namespace InventoryManagement.Domain.Inventory
{
    public class OperationInventory
    {
        public int Id { get; private set; }
        public int OperatorId { get; private set; }
        public int OrderId { get; private set; }
        public bool OperationType { get; private set; }
        public DateTime OperationDate { get; private set; }
        public int CurrentCount { get; private set; }
        public string Description { get; private set; }
        public int Count { get; private set; }

        public int InventoryId { get; private set; }
        public InventoryEntity Inventory { get; private set; }

        public OperationInventory(int operatorId, int orderId, bool operationType, int currentCount,
            string description, int count, int inventoryId)
        {
            OperatorId = operatorId;
            OrderId = orderId;
            OperationType = operationType;
            CurrentCount = currentCount;
            Description = description;
            Count = count;
            InventoryId = inventoryId;
        }
    }
}