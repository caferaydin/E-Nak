using E_Nak.Application.Abstract;
using E_Nak.Application.Abstract.Repositories.Read;
using E_Nak.Application.Abstract.Repositories.Write;
using E_Nak.Persistence.Concretes;
using E_Nak.Persistence.Context;
using E_Nak.Persistence.Repositories.Read;
using E_Nak.Persistence.Repositories.Write;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace E_Nak.Persistence.Extensions
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceService(this IServiceCollection services)
        {

            services.AddDbContext<MsSqlDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));
            services.AddSingleton<IVehicleService, VehicleService>();


            #region Repository

            services.AddScoped<IVehicleReadRepository, VehicleReadRepository>();
            services.AddScoped<IVehicleWriteRepository, VehicleWriteRepository>();


            #endregion

        }
    }
}
