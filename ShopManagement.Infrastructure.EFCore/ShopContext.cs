using Microsoft.EntityFrameworkCore;
using ShopManagement.Domain.Comment;
using ShopManagement.Domain.Product;
using ShopManagement.Domain.ProductCategory;
using ShopManagement.Domain.ProductPicture;
using ShopManagement.Domain.Slider;
using ShopManagement.Infrastructure.EFCore.Mapping;

namespace ShopManagement.Infrastructure.EFCore
{
    public class ShopContext : DbContext
    {
        public DbSet<ProductCategoryEntity> productCategories { get; set; }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<ProductPictureEntity> ProductPictures { get; set; }
        public DbSet<SliderEntity> Sliders { get; set; }
        public DbSet<CommentEntity> Comments { get; set; }

        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(ProductCategoryMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
