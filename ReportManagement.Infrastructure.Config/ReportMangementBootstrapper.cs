using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ReportManagement.Application;
using ReportManagement.Application.Contracts.SiteVisit;
using ReportManagement.Infrastructure.EFCore;
using ReportManagement.Infrastructure.EFCore.Repository;
using ReportManagment.Domain.SiteVisit;

namespace ReportManagement.Infrastructure.Config
{
    public class ReportMangementBootstrapper
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {
            services.AddTransient<ISiteVisitApplication, SiteVisitApplication>();
            services.AddTransient<ISiteVisitRepository, SiteVisitRepository>();

            services.AddDbContext<ReportContext>(x => x.UseSqlServer(connectionString));
        }
    }
}
