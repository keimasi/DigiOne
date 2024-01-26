using System.Collections.Generic;
using _0_Framwork.Application;
using Microsoft.Extensions.Configuration;
using ShopManagement.Application.Contracts.Order;
using ShopManagement.Domain.Order;
using ShopManagement.Domain.Order.Service;

namespace ShopManagement.Application
{
    public class OrderApplication : IOrderApplication
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IAuthenticationHelper _authenticationHelper;
        private readonly IConfiguration _configuration;
        private readonly IShopInventoryAcl _shopInventoryAcl;

        public OrderApplication(IOrderRepository orderRepository, IAuthenticationHelper authenticationHelper, IConfiguration configuration, IShopInventoryAcl shopInventoryAcl)
        {
            _orderRepository = orderRepository;
            _authenticationHelper = authenticationHelper;
            _configuration = configuration;
            _shopInventoryAcl = shopInventoryAcl;
        }

        public long PlaceOrder(Cart cart)
        {
            var currentUserId = _authenticationHelper.GetCurrentUserId();
            var order = new OrderEntity(currentUserId, cart.TotalAmount, cart.DiscountAmount, cart.AmountPaid);

            foreach (var item in cart.Items)
            {
                var orderItem = new OrderItem(item.Id, item.Count, int.Parse(item.Price), item.DiscountRate);
                order.AddItem(orderItem);
            }

            _orderRepository.Create(order);
            _orderRepository.Save();
            return order.Id;
        }

        public string PaymentSucceeded(int orderId, long refId)
        {
            var order = _orderRepository.Get(orderId);
            order.SuccessfulPayment(refId);

            var symbol = _configuration.GetSection("Symbol").Value;
            var issueTracking = CodeGenerator.Generate(symbol);
            order.SetIssueTracking(issueTracking);

            if (!_shopInventoryAcl.DecreaseFromInventory(order.Items)) return "";

            _orderRepository.Save();
            return issueTracking;
        }

        public void Cancel(int id)
        {
            var order = _orderRepository.Get(id);
            order.Cancel();
            _orderRepository.Save();
        }

        public double GetAmountBy(int id)
        {
            return _orderRepository.GetAmountBy(id);
        }

        public List<OrderVIewModel> GerOrders()
        {
            return _orderRepository.GerOrders();
        }

        public List<OrderItemViewModel> GerOrderItems(int orderId)
        {
            return _orderRepository.GerOrderItems(orderId);
        }
    }
}