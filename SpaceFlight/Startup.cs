using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using SpaceFlight.Data;
using SpaceFlight.Data.Repositorio;
using SpaceFlight.Interface.Repositorio;
using SpaceFlight.Interface.Service;
using SpaceFlight.Services;

namespace SpaceFlight
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            string mySqlConnection = Configuration.GetConnectionString("MySqlConnectionString");

            services.AddDbContextPool<AppDBContext>(options =>
                options.UseMySql(mySqlConnection,
                    ServerVersion.AutoDetect(mySqlConnection)));

            services.AddScoped<IArticlesRepositorio, ArticlesRepositorio>();
            services.AddScoped<IArticlesService, ArticlesService>();

            services.AddMvc();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "SpaceFlight", Version = "v1" });
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SpaceFlight v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
