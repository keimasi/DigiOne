using System.Collections.Generic;
using ShopManagement.Application.Contracts.Order;

namespace _01_DigiOneQuery.Contracts.Order
{
    public interface ICartCalculatorService
    {
        Cart ComputingCart(List<CartItem> cartItems);
    }
}
