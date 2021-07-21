using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using api.Data;
using api.Services;
using api.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace api.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<ITokenService, TokenService>();
            services.AddDbContext<datacontext>(options =>
            {
                options.UseSqlite(config.GetConnectionString("DefaultConnection"));
            });
            return services;
        }
    }
}