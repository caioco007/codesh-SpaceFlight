using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SpaceFlight.Data;
using SpaceFlight.Data.Repositorio;
using SpaceFlight.Interface.Repositorio;
using SpaceFlight.Interface.Service;
using SpaceFlight.Services;

namespace SpaceFlight.Crosscutting.IoC
{
    public static class Bootstrapper
    {
        public static void RegisterServices(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<AppDBContext>(options =>
                    options.UseMySql(configuration.GetConnectionString("MySqlConnectionString"),null));

            services.AddTransient<IArticlesService, ArticlesService>();
            services.AddTransient<IArticlesRepositorio, ArticlesRepositorio>();

        }

    }
}
