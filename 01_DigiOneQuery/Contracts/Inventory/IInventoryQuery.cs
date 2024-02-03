namespace _01_DigiOneQuery.Contracts.Inventory
{
    public interface IInventoryQuery
    {
        StockStatus CheckStock(IsInStock command);
    }
}
