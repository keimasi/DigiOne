using System.Collections.Generic;

namespace ShopManagement.Application.Contracts.Order
{
    public interface IOrderApplication
    {
        long PlaceOrder(Cart cart);
        string PaymentSucceeded(int orderId,long refId);
        void Cancel(int id);
        double GetAmountBy(int id);
        List<OrderVIewModel> GetOrders();
        List<OrderItemViewModel> GetOrderItems(int orderId);
        string GetTotalSales();
        int GetSalesNumber();
    }
}
