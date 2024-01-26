namespace InventoryManagement.Application.Contracts.Inventory
{
    public class DecreaseInventory
    {
        public int InventoryId { get; set; }
        public int ProductId { get; set; }
        public string Description { get; set; }
        public int OrderId { get; set; }
        public int Count { get; set; }

        public DecreaseInventory()
        {
        }

        public DecreaseInventory(int productId, string description, int orderId, int count)
        {
            ProductId = productId;
            Description = description;
            OrderId = orderId;
            Count = count;
        }
    }
}