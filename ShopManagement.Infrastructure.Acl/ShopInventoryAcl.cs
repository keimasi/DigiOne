using System.Collections.Generic;
using System.Linq;
using InventoryManagement.Application.Contracts.Inventory;
using ShopManagement.Domain.Order;
using ShopManagement.Domain.Order.Service;

namespace ShopManagement.Infrastructure.Acl
{
    public class ShopInventoryAcl:IShopInventoryAcl
    {
        private readonly IInventoryApplication _inventoryApplication;

        public ShopInventoryAcl(IInventoryApplication inventoryApplication)
        {
            _inventoryApplication = inventoryApplication;
        }

        public bool DecreaseFromInventory(List<OrderItem> items)
        {
            var command = items.Select(orderItem => new DecreaseInventory(orderItem.ProductId, "خرید مشتری", orderItem.OrderId, orderItem.Count)).ToList();
            return _inventoryApplication.Decrease(command).IsSuccess;
        }
    }
}
