using E_Nak.Application.Abstract;
using E_Nak.Persistence.Concretes;
using E_Nak.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Nak.Persistence.Extensions
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceService(this IServiceCollection services)
        {

            services.AddDbContext<MsSqlDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));
            services.AddSingleton<IVehicleService, VehicleService>();

        }
    }
}
