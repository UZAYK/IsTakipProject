using FluentValidation;
using FluentValidation.AspNetCore;
using IsTakip.Business.Concrete;
using IsTakip.Business.DiContainer;
using IsTakip.Business.Interfaces;
using IsTakip.Business.ValidationRules.FluentValidation;
using IsTakip.DataAccess.Concrete.EntityFrameworkCore.Context;
using IsTakip.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using IsTakip.DataAccess.Interfaces;
using IsTakip.DTO.DTOs.AciliyetDTOs;
using IsTakip.DTO.DTOs.AppUserDtos;
using IsTakip.DTO.DTOs.GorevDtos;
using IsTakip.DTO.DTOs.RaporDtos;
using IsTakip.Entities.Concrete;
using IsTakip.Web.CustomCollectionExtension;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace IsTakip.Web
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddContainerWithDependencies();

            services.AddDbContext<IsTakipContext>();

            services.AddIdentityConfigure();

            services.AddAutoMapper(typeof(Startup));

           

            services.AddControllersWithViews().AddFluentValidation()
                  .AddRazorRuntimeCompilation();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,
            UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            IdentityInitializer.SeedData(userManager, roleManager).Wait();
            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area}/{controller=Home}/{action=Index}/{id?}"
                    );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                    );
            });
        }
    }
}
