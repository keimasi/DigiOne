using System;
using _0_Framwork.Domain;

namespace DiscountManagement.Domain.CustomerDiscount
{
    public class CustomerDiscountEntity : EntityBace
    {
        public int DiscountRate { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public string Description { get; private set; }
        public int ProductId { get; private set; }

        public CustomerDiscountEntity(int discountRate, DateTime startDate, DateTime endDate, string description, int productId)
        {
            DiscountRate = discountRate;
            StartDate = startDate;
            EndDate = endDate;
            Description = description;
            ProductId = productId;
        }

        public void Edit(int discountRate, DateTime startDate, DateTime endDate, string description, int productId)
        {
            DiscountRate = discountRate;
            StartDate = startDate;
            EndDate = endDate;
            Description = description;
            ProductId = productId;
        }
    }
}
