using Microsoft.Extensions.DependencyInjection;

namespace mscarservice.Domain
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDomainServices(this IServiceCollection services)
        {
            // Register Domain-layer services here
            // Example: services.AddScoped<IDomainService, DomainService>();
            return services;
        }
    }
}

