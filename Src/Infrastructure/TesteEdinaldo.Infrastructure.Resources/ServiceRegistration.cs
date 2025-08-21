using Microsoft.Extensions.DependencyInjection;
using TesteEdinaldo.Application.Interfaces;
using TesteEdinaldo.Infrastructure.Resources.Services;

namespace TesteEdinaldo.Infrastructure.Resources
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddResourcesInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<ITranslator, Translator>();

            return services;
        }
    }
}
