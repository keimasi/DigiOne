using _0_Framwork.Domain;

namespace DiscountManagement.Domain.ColleagueDiscount
{
    public class ColleagueDiscountEntity : EntityBace
    {
        public int DiscountRate { get; private set; }
        public int ProductId { get; private set; }
        public bool IsRemoved { get; private set; }

        public ColleagueDiscountEntity(int discountRate, int productId)
        {
            DiscountRate = discountRate;
            ProductId = productId;
            IsRemoved = false;
        }

        public void Edit(int discountRate, int productId)
        {
            DiscountRate = discountRate;
            ProductId = productId;
        }

        public void Remove()
        {
            IsRemoved=true;
        }

        public void Restore()
        {
            IsRemoved=false;
        }
    }
}
