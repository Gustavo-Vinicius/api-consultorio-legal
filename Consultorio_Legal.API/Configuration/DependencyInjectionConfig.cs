using Consultorio_Legal.DATA.Repository;
using Consultorio_Legal.MANAGER.Implementation;
using Consultorio_Legal.MANAGER.Interfaces;

namespace Consultorio_Legal.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void UseDependencyInjectionConfiguration(this IServiceCollection services)
        {
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IClienteManager, ClienteManager>();

        }
    }
}