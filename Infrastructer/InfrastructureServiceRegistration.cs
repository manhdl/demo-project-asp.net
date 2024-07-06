using Microsoft.Extensions.DependencyInjection;

namespace Infrastructer
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastrureService(this IServiceCollection services) 
        {
            return services;
        }
    }
}
