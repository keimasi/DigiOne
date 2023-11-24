using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopManagement.Domain.ProductPicture;

namespace ShopManagement.Infrastructure.EFCore.Mapping
{
    public class ProductPictureMapping:IEntityTypeConfiguration<ProductPictureEntity>
    {
        public void Configure(EntityTypeBuilder<ProductPictureEntity> builder)
        {
            builder.ToTable("ProductPictures");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Picture).HasMaxLength(1000).IsRequired();
            builder.Property(x => x.PictureTitle).HasMaxLength(500).IsRequired();
            builder.Property(x => x.PictureAlt).HasMaxLength(500).IsRequired();

            builder.HasOne(x => x.Product)
                .WithMany(x => x.ProductPicture)
                .HasForeignKey(x => x.ProductId);
        }
    }
}
