using InventoryManagement.Domain.Inventory;
using InventoryManagement.Infrastructure.EFCore.Mapping;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Infrastructure.EFCore
{
    public class InventoryContext : DbContext
    {
        public DbSet<InventoryEntity> Inventory { get; set; }

        public InventoryContext(DbContextOptions<InventoryContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(InventoryMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
