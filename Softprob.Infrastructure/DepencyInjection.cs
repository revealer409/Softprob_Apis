
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Softprob.Infrastructure
{
    public static class DepencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            var assembly= Assembly.GetExecutingAssembly();
 

            return services;
        }
    }
}
