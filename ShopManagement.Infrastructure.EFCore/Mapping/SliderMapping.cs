using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopManagement.Domain.Slider;

namespace ShopManagement.Infrastructure.EFCore.Mapping
{
    public class SliderMappingL:IEntityTypeConfiguration<SliderEntity>
    {
        public void Configure(EntityTypeBuilder<SliderEntity> builder)
        {
            builder.ToTable("Sliders");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Picture).HasMaxLength(1000).IsRequired();
            builder.Property(x => x.PictureTitle).HasMaxLength(300).IsRequired();
            builder.Property(x => x.PictureAlt).HasMaxLength(300).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(600).IsRequired();
            builder.Property(x => x.Link).HasMaxLength(500);
        }
    }
}
