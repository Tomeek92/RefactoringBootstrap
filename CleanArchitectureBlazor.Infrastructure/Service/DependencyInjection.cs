using CleanArchitectureBlazor.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitectureBlazor.Infrastructure.Service
{
    public static class DependencyInjection
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CleanArchitectureBlazorDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("CleanArchitectureBlazorDbContext")));
        }
    }
}
