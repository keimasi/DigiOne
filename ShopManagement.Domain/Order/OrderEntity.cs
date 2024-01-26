using System.Collections.Generic;
using _0_Framwork.Domain;

namespace ShopManagement.Domain.Order
{
    public class OrderEntity : EntityBace
    {
        public int UserId { get; private set; }
        public double TotalAmount { get; private set; }
        public double DiscountAmount { get; private set; }
        public double PayAmount { get; private set; }
        public bool IsPaid { get; private set; }
        public bool IsCanceled { get; private set; }
        public string IssueTracking { get; private set; }
        public long RefId { get; private set; }
        public List<OrderItem> Items { get; private set; }

        public OrderEntity(int userId, double totalAmount, double discountAmount, double payAmount)
        {
            UserId = userId;
            TotalAmount = totalAmount;
            DiscountAmount = discountAmount;
            PayAmount = payAmount;
            Items = new List<OrderItem>();
            IsPaid = false;
            IsCanceled = false;
            RefId = 0;
        }

        public void SuccessfulPayment(long refId)
        {
            IsPaid = true;

            if (RefId != 0)
                RefId = refId;
        }

        public void Cancel()
        {
            IsCanceled = true;
        }

        public void SetIssueTracking(string number)
        {
            IssueTracking = number;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
    }
}
