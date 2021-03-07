using IsTakip.Business.Concrete;
using IsTakip.Business.CustomLogger;
using IsTakip.Business.Interfaces;
using IsTakip.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using IsTakip.DataAccess.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace IsTakip.Business.DiContainer
{
    public static class CollectionExtension
    {
        public static void AddContainerWithDependencies(this IServiceCollection services)
        {
            services.AddScoped<IGorevService, GorevManager>();
            services.AddScoped<IRaporService, RaporManager>();
            services.AddScoped<IAciliyetService, AciliyetManager>();
            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IDosyaService, DosyaManager>();
            services.AddScoped<IBildirimService, BildirimManager>();

            services.AddScoped<IGorevDal, EfGorevRepository>();
            services.AddScoped<IRaporDal, EfRaporRepository>();
            services.AddScoped<IAciliyetDal, EfAciliyetRepository>();
            services.AddScoped<IAppUserDal, EfAppUserRepository>();
            services.AddScoped<IBildirimDal, EfBildirimRepository>();


            services.AddTransient<ICustomLogger, NLogLogger>();
        }
    }
}
