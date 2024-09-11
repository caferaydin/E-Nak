using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace E_Nak.Application
{
    public static class ApplicationServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddHttpClient();

        }
    }
}
