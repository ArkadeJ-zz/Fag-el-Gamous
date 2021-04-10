using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fag_el_Gamous.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Fag_el_Gamous
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {


            //services.AddDbContext<TourDbContext>(options =>
            //{
            //    options.UseSqlite(Configuration["ConnectionStrings:TourConnection"]);

            //    //old sqlserver
            //    //options.UseSqlServer(Configuration["ConnectionStrings:TourConnection"]);
            //});

            //services.AddDbContext<IdentityContext>(opts =>
            //   opts.UseNpgsql(Configuration[
            //       "ConnectionStrings:IdentityConnection"]));
            //services.AddIdentity<IdentityUser, IdentityRole>()
            //   .AddEntityFrameworkStores<IdentityContext>();

            //services.AddScoped<IMummyRepository, EFMummyRepository>();


            services.AddDbContext<waterbuffaloContext>(options =>
            {
                options.UseNpgsql(Configuration["ConnectionStrings:postgresConnection"]);
            });


            services.AddControllersWithViews();
            services.AddRazorPages();

            //services.AddAuthentication()
            //    .AddGoogle(options =>
            //    {
            //        IConfigurationSection googleAuthNSection =
            //            Configuration.GetSection("Authentication:Google");

            //        options.ClientId = googleAuthNSection["969084770289-r9nid6eqvo3oi0hppathovg4q5l6b9ec"];
            //        options.ClientSecret = googleAuthNSection["JFrbWccqRn0UMOK9yboBd8yc"];


            //        //https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-5.0&tabs=windows
            //        //options.ClientId = googleAuthNSection["ClientId"];
            //        //options.ClientSecret = googleAuthNSection["ClientSecret"];
            //    });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    "pageNum",
                    "Index/{pageNum}",
                    new { Controller = "MasterBurial2", action = "Index" }
                    );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();


                //endpoints.MapControllerRoute(
                //    name: "MasterBurial2",
                //    pattern:"{controller=MasterBurial2}/{action=Index}");



            });


        }
    }
}
