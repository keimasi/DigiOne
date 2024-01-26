using System.Collections.Generic;
using System.Linq;
using _0_Framwork.Application;
using _0_Framwork.Infrastructure;
using AccountManagement.Infrastructure.EFCore;
using ShopManagement.Application.Contracts.Order;
using ShopManagement.Domain.Order;

namespace ShopManagement.Infrastructure.EFCore.Repository
{
    public class OrderRepository : RepositoryBace<int, OrderEntity>, IOrderRepository
    {
        private readonly ShopContext _context;
        private readonly AccountContext _accountContext;

        public OrderRepository(ShopContext context, AccountContext accountContext) : base(context)
        {
            _context = context;
            _accountContext = accountContext;
        }

        public double GetAmountBy(int id)
        {
            var order = _context.Orders.Select(x => new { x.Id, x.PayAmount }).FirstOrDefault(x => x.Id == id);
            if (order != null)
                return order.PayAmount;
            return 0;
        }

        public List<OrderVIewModel> GerOrders()
        {
            var account = _accountContext.Accounts.Select(x => new { x.FullName, x.Id }).ToList();

            return _context.Orders.ToList().Select(x => new OrderVIewModel
            {
                Id = x.Id,
                UserFullName = account.FirstOrDefault(y => y.Id == x.UserId)?.FullName,
                TotalAmount = x.TotalAmount,
                DiscountAmount = x.DiscountAmount,
                PayAmount = x.PayAmount,
                IsPaid = x.IsPaid,
                IsCanceled = x.IsCanceled,
                IssueTracking = x.IssueTracking,
                RefId = x.RefId,
                CreateDate = x.CreateDate.ToFarsi()
            }).ToList();
        }

        public List<OrderItemViewModel> GerOrderItems(int orderId)
        {
            var productName = _context.Products.Select(x => new { x.Id, x.Name }).ToList();
            var order = _context.Orders.FirstOrDefault(x => x.Id == orderId);

            return order.Items.Select(x => new OrderItemViewModel
            {
                ProductName = productName.FirstOrDefault(y=>y.Id==x.ProductId)?.Name,
                Count = x.Count,
                UnitPrice = x.UnitPrice.ToMoney(),
                DiscountRate = x.DiscountRate
            }).ToList();
        }
    }
}
