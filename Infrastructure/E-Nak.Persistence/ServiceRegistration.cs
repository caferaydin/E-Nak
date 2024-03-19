using E_Nak.Application.Repositories.Read.Account;
using E_Nak.Application.Repositories.Write.Account;
using E_Nak.Persistence.Context;
using E_Nak.Persistence.Repositories.Read.Account;
using E_Nak.Persistence.Repositories.Write.Account;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace E_Nak.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceService(this IServiceCollection services)
        {
            #region DbContext
            services.AddDbContext<MsSqlDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));
            #endregion

            #region Repository

            services
                .AddScoped<ICompanyReadRepository, CompanyReadRepository>()
                .AddScoped<ICompanyWriteRepository, CompanyWriteRepository>();

            services
                .AddScoped<IProducerReadRepository, ProducerReadRepository>()
                .AddScoped<IProducerWriteRepository, ProducerWriteRepository>();

            services
                .AddScoped<IIndividualReadRepository, IndividualReadRepository>()
                .AddScoped<IIndividualWriteRepository, IndividualWriteRepository>();

            //services
            //    .AddScoped<ITransportReadRepository, TransportReadRepository>()
            //    .AddScoped<ITransportWriteRepository, TransportWriteRepository>();

            ////services
            ////    .AddScoped<IVehicleReadRepository, VehicleReadRepository>()
            ////    .AddScoped<IVehicleWriteRepository, VehicleWriteRepository>();

            //services
            //    .AddScoped<IBusinessDataReadRepository, BusinessDataReadRepository>()
            //    .AddScoped<IBusinessDataWriteRepository, BusinessDataWriteRepository>();


            #endregion

            #region Service

            //services
            //.AddScoped<IVehicleService, VehicleService>()
            //.AddScoped<ITransportService, TransportService>()
            //.AddScoped<IPreliminaryOffersService, PreliminaryOffersService>()
            //.AddScoped<ICompanyService, CompanyService>();

            //.AddScoped<IDriveService, DriveServices>();

            #endregion

        }
    }
}
