using DiscountManagement.Domain.CustomerDiscount;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DiscountManagement.Infrastructure.EFCore.Mapping
{
    public class CustomerDiscountMapping : IEntityTypeConfiguration<CustomerDiscountEntity>
    {
        public void Configure(EntityTypeBuilder<CustomerDiscountEntity> builder)
        {
            builder.ToTable("CustomerDiscounts");
            builder.HasKey(x => x.Id);
        }
    }
}
