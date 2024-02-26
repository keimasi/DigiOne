using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReportManagment.Domain.SiteVisit;

namespace ReportManagement.Infrastructure.EFCore.Mapping
{
    public class SiteVisitMapping:IEntityTypeConfiguration<SiteVisitEntity>
    {
        public void Configure(EntityTypeBuilder<SiteVisitEntity> builder)
        {
            builder.ToTable("SiteVisit");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Ip).HasMaxLength(20);
        }
    }
}
