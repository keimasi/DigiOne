namespace InventoryManagement.Application.Contracts.Inventory
{
    public class DecreaseInventory
    {
        public int InventoryId { get; set; }
        public int ProductId { get; set; }
        public string Description { get; set; }
        public int OrderId { get; set; }
        public int Count { get; set; }
    }
}