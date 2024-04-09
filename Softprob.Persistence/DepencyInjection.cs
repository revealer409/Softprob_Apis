
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Softprob.Persistence.Context;
using System.Reflection;

namespace Softprob.Persistence
{
    public static class DepencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            var assembly = Assembly.GetExecutingAssembly();

            services.AddDbContext<ApplicationDbContext>
                (option => option.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            return services;
        }
    }
}
