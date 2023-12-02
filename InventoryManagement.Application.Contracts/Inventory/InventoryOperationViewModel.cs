namespace InventoryManagement.Application.Contracts.Inventory
{
    public class InventoryOperationViewModel
    {
        public int Id { get; set; }
        public int OperatorId { get; set; }
        public string OperatorName { get; set; }
        public int OrderId { get; set; }
        public bool OperationType { get; set; }
        public string OperationDate { get; set; }
        public int CurrentCount { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
    }
}
