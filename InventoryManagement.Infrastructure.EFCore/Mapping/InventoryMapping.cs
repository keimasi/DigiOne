using InventoryManagement.Domain.Inventory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryManagement.Infrastructure.EFCore.Mapping
{
    public class InventoryMapping:IEntityTypeConfiguration<InventoryEntity>
    {
        public void Configure(EntityTypeBuilder<InventoryEntity> builder)
        {
            builder.ToTable("Inventory");
            builder.HasKey(x => x.Id);

            builder.OwnsMany(x => x.OperationInventories, modelBuilder =>
            {
                modelBuilder.HasKey(x => x.Id);
                modelBuilder.ToTable("OperationInventory");
                modelBuilder.Property(x => x.Description).HasMaxLength(500);
                modelBuilder.WithOwner(x=>x.Inventory).HasForeignKey(x => x.InventoryId);
            });
        }
    }
}
