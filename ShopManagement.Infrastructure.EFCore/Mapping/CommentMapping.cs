using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopManagement.Domain.Comment;

namespace ShopManagement.Infrastructure.EFCore.Mapping
{
    public class CommentMapping : IEntityTypeConfiguration<CommentEntity>
    {
        public void Configure(EntityTypeBuilder<CommentEntity> builder)
        {
            builder.ToTable("Comments");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).HasMaxLength(300).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(300).IsRequired();
            builder.Property(x => x.Message).HasMaxLength(1500).IsRequired();

            builder.HasOne(x=>x.Product).WithMany(x=>x.Comments).HasForeignKey(x=>x.ProductId);
        }
    }
}
