using E_Nak.Application.Abstract.Repositories.Read;
using E_Nak.Application.Abstract.Repositories.Write;
using E_Nak.Application.Abstract.Service;
using E_Nak.Application.Abstract.Service.PeopleInformation;
using E_Nak.Persistence.Concretes;
using E_Nak.Persistence.Context;
using E_Nak.Persistence.Repositories.Read;
using E_Nak.Persistence.Repositories.Write;
using E_Nak.Persistence.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace E_Nak.Persistence.Extensions
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceService(this IServiceCollection services)
        {
            #region DbContext
            services.AddDbContext<MsSqlDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));
            #endregion

            #region Repository

            services.AddScoped<ICompanyReadRepository, CompanyReadRepository>();
            services.AddScoped<ICompanyWriteRepository, CompanyWriteRepository>();

            services.AddScoped<IDriveReadRepository, DriveReadRepository>();
            services.AddScoped<IDriveWriteRepository, DriveWriteRepository>();

            services.AddScoped<IPreliminaryOffersReadRepository, PreliminaryOffersReadRepository>();
            services.AddScoped<IPreliminaryOffersWriteRepository, PreliminaryOffersWriteRepository>();

            services.AddScoped<ITransportReadRepository, TransportReadRepository>();
            services.AddScoped<ITransportWriteRepository, TransportWriteRepository>();

            services.AddScoped<IVehicleReadRepository, VehicleReadRepository>();
            services.AddScoped<IVehicleWriteRepository, VehicleWriteRepository>();

            #endregion

            #region Service
            services.AddScoped<IVehicleService, VehicleService>();
            services.AddScoped<ITransportService, TransportService>();
            services.AddScoped<IPreliminaryOffersService, PreliminaryOffersService>();
            services.AddScoped<IDriveService, DriveServices>();

            #endregion

        }
    }
}
