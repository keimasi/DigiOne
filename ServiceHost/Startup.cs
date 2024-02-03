using System.Collections.Generic;
using _0_Framwork.Application;
using DiscountManagement.Infrastructure.Config;
using InventoryManagement.Infrastructure.Config;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ShopManagement.Infrastructure.Config;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using _0_Framework.Application;
using _0_Framwork.Application.ZarinPal;
using AccountManagement.Infrastructure.Config;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using _0_Framwork.Infrastructure;
using InventoryManagement.Presentation.API;

namespace ServiceHost
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpContextAccessor();
            var connectionString = Configuration.GetConnectionString("DigiOneDB");

            ShopMangementBootstrapper.Configure(services, connectionString);
            DiscountMangementBootstrapper.Configure(services, connectionString);
            InventoryMangementBootstrapper.Configure(services, connectionString);
            AccountMangementBootstrapper.Configure(services, connectionString);

            services.AddSingleton(HtmlEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Arabic));
            services.AddSingleton<IPasswordHasher, PasswordHasher>();
            services.AddTransient<IFileUpload, FileUpload>();
            services.AddTransient<IAuthenticationHelper, AuthenticationHelper>();
            services.AddTransient<IZarinPalFactory, ZarinPalFactory>();

            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.Lax;
            });

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, o =>
                {
                    o.LoginPath = new PathString("/Login");
                    o.LogoutPath = new PathString("/Login");
                    o.AccessDeniedPath = new PathString("/AccessDenied");
                });

            services.AddAuthorization(x =>
            {
                x.AddPolicy("AdminArea",
                    y => y.RequireRole(new List<string> { Roles.Admin, Roles.storekeeper }));

                x.AddPolicy("Account",
                    y => y.RequireRole(new List<string> { Roles.Admin }));

                x.AddPolicy("Discounts",
                    y => y.RequireRole(new List<string> { Roles.Admin }));
            });

            services.AddRazorPages()
                .AddMvcOptions(x => x.Filters.Add<PageFilter>())
                .AddRazorPagesOptions(x =>
                {
                    x.Conventions.AuthorizeAreaFolder("Administrator", "/", "AdminArea");
                    x.Conventions.AuthorizeAreaFolder("Administrator", "/Account", "Account");
                    x.Conventions.AuthorizeAreaFolder("Administrator", "/Discounts", "Discounts");
                })
                .AddApplicationPart(typeof(InventoryController).Assembly);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseAuthentication();

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseCookiePolicy();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
            });
        }
    }
}
