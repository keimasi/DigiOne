namespace InventoryManagement.Application.Contracts.Inventory
{
    public class InventoryViewModel
    {
        public int Id { get; set; }
        public string Product { get; set; }
        public double UnitPrice { get; set; }
        public bool InStock { get; set; }
        public int CurrentCount { get; set; }
    }
}