using _0_Framwork.Domain;

namespace ShopManagement.Domain.Order
{
    public class OrderItem : EntityBace
    {
        public int ProductId { get; private set; }
        public int Count { get; private set; }
        public double UnitPrice { get; private set; }
        public int DiscountRate { get; private set; }

        public int OrderId { get; private set; }
        public OrderEntity Order { get; private set; }

        public OrderItem(int productId, int count, double unitPrice, int discountRate)
        {
            ProductId = productId;
            Count = count;
            UnitPrice = unitPrice;
            DiscountRate = discountRate;
        }
    }
}