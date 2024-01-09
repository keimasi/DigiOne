using System.Collections.Generic;
using ShopManagement.Application.Contracts.Order;

namespace _01_DigiOneQuery.Contracts.Product
{
    public interface IProductQuery
    {
        List<ProductQueryModel> Search(string value);
        ProductQueryModel GetProduct(string slug);
        List<CartItem> CheckInventoryStatus(List<CartItem> cartItems);
    }
}
