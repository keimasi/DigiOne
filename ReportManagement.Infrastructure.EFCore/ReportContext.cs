using Microsoft.EntityFrameworkCore;
using ReportManagement.Infrastructure.EFCore.Mapping;
using ReportManagment.Domain.SiteVisit;

namespace ReportManagement.Infrastructure.EFCore
{
    public class ReportContext : DbContext
    {
        public DbSet<SiteVisitEntity> SiteVisits { get; set; }

        public ReportContext(DbContextOptions<ReportContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(SiteVisitMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
