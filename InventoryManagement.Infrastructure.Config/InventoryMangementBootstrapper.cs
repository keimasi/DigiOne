using _0_Framwork.Infrastructure;
using _01_DigiOneQuery.Contracts.Inventory;
using _01_DigiOneQuery.Query;
using InventoryManagement.Application;
using InventoryManagement.Application.Contracts.Inventory;
using InventoryManagement.Domain.Inventory;
using InventoryManagement.Infrastructure.Config.Permissions;
using InventoryManagement.Infrastructure.EFCore;
using InventoryManagement.Infrastructure.EFCore.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace InventoryManagement.Infrastructure.Config
{
    public class InventoryMangementBootstrapper
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {
            services.AddTransient<IInventoryApplication, InventoryApplication>();
            services.AddTransient<IInventoryRepository, InventoryRepository>();

            services.AddTransient<IPermissionExposer, InventoryPermissionsExposer>();

            services.AddTransient<IInventoryQuery, InventoryQuery>();

            services.AddDbContext<InventoryContext>(x => x.UseSqlServer(connectionString));
        }
    }
}
