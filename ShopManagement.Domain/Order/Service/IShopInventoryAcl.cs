using System.Collections.Generic;

namespace ShopManagement.Domain.Order.Service
{
    public interface IShopInventoryAcl
    {
        bool DecreaseFromInventory(List<OrderItem> items);
    }
}
