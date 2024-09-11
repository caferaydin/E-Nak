using E_Nak.Domain.Entities.Account;
using E_Nak.Persistence.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace E_Nak.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static void AddPersistenceService(this IServiceCollection services, IConfiguration configuration)
        {
            #region DbContext
            services.AddDbContext<ENakDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("PostgreSQL")));


            services.AddIdentity<User, Role>(options =>
            {
                options.Password.RequiredLength = 3;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
            })
                .AddEntityFrameworkStores<ENakDbContext>()
                .AddDefaultTokenProviders();

            #endregion

            #region Repository




            #endregion

            #region Service



            #endregion

        }
    }
}
