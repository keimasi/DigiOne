﻿namespace InventoryManagement.Application.Contracts.Inventory
{
    public class IncreaseInventory
    {
        public int InventoryId { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }
    }
}
