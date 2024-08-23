using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CleanArchitucture.Application
{
    public static class ConfigureService
    {
        public static IServiceCollection RegisterApplicationService(this IServiceCollection services)
        {
            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly());

            });
            return services;
        }
    }
}
