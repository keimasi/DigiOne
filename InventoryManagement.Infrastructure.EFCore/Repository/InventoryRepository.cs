using System.Collections.Generic;
using System.Linq;
using _0_Framwork.Application;
using _0_Framwork.Infrastructure;
using InventoryManagement.Application.Contracts.Inventory;
using InventoryManagement.Domain.Inventory;
using ShopManagement.Infrastructure.EFCore;

namespace InventoryManagement.Infrastructure.EFCore.Repository
{
    public class InventoryRepository : RepositoryBace<int, InventoryEntity>, IInventoryRepository
    {
        private readonly ShopContext _shopContext;
        private readonly InventoryContext _context;

        public InventoryRepository(InventoryContext context, ShopContext shopContext) : base(context)
        {
            _context = context;
            _shopContext = shopContext;
        }


        public EditInventory GetDetails(int id)
        {
            return _context.Inventory.Select(x => new EditInventory
            {
                ProductId = x.ProductId,
                UnitPrice = x.UnitPrice,
                Id = x.Id
            }).FirstOrDefault(x => x.Id == id);
        }

        public List<InventoryViewModel> GetInventories()
        {
            var products = _shopContext.Products.ToDictionary(x => x.Id, x => x.Name);

            return _context.Inventory.Select(x => new InventoryViewModel
            {
                Id = x.Id,
                Product = products.ContainsKey(x.ProductId) ? products[x.ProductId] : "Unknown Product",
                UnitPrice = x.UnitPrice.ToMoney(),
                InStock = x.InStock,
                CurrentCount = x.CalculationCurrentCount(),
                CreateDate = x.CreateDate.ToFarsi()
            }).ToList();
        }

        public InventoryEntity GetBy(int productId)
        {
            return _context.Inventory.FirstOrDefault(x => x.ProductId == productId);
        }

        public List<InventoryOperationViewModel> GetInventoryOperationLog(int inventoryId)
        {
            var inventory = _context.Inventory.FirstOrDefault(x => x.Id == inventoryId);
            return inventory.OperationInventories.Select(x => new InventoryOperationViewModel
            {
                Id = x.Id,
                OperatorId = 1,
                OperatorName = "سهیل",
                OrderId = 0,
                OperationType = x.OperationType,
                OperationDate = x.OperationDate.ToFarsi(),
                CurrentCount = x.CurrentCount,
                Description = x.Description,
                Count = x.Count
            }).OrderByDescending(x=>x.Id).ToList();
        }
    }
}
