using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Deeneme2.Models;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;

namespace Deeneme2
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddHttpClient().AddControllers();
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                   builder => builder
                   .SetIsOriginAllowed((host) => true)
                   .AllowAnyMethod()
                   .AllowAnyHeader()
                   .AllowCredentials());
            });

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Climax - Get Customer HTTP API",
                    Version = "v1",
                    Description = "The Get Customer Service HTTP API"
                });
            });

            // Entity Framework DbContext eklemesi
            services.AddDbContext<TravelFormDataContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("TravelFormDataConnection")));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseCors("CorsPolicy");

            app.UseRouting();

            app.UseAuthorization();

            app.UseSwagger();
            app.UseSwaggerUI(setup =>
            {
                setup.SwaggerEndpoint("/swagger/v1/swagger.json", "Climax - Get Customer HTTP API V1");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
                endpoints.MapControllers();
            });
        }
    }
}
