using AccountManagement.Domain.Role;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccountManagement.Infrastructure.EFCore.Mapping
{
    public class RoleMapping:IEntityTypeConfiguration<RoleEntity>
    {
        public void Configure(EntityTypeBuilder<RoleEntity> builder)
        {
            builder.ToTable("Roles");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).HasMaxLength(100).IsRequired();
            builder.OwnsMany(x => x.Permissions, y =>
            {
                y.HasKey(x => x.Id);
                y.ToTable("RolePermissions");
                y.Ignore(x => x.Name);
                y.WithOwner(x => x.Role);
            });
        }
    }
}
