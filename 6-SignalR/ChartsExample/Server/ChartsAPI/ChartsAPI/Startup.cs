using ChartsAPI.Hubs;
using ChartsAPI.Models;
using ChartsAPI.Subscription;
using ChartsAPI.Subscription.Middleware;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace ChartsAPI
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
            services.AddSignalR();

            services.AddCors(opt => opt.AddDefaultPolicy(policy =>
            {
                policy
                .AllowCredentials()
                .AllowAnyHeader()
                .AllowAnyMethod()
              
                .SetIsOriginAllowed(x => true);
            }
            ));


            services.AddSingleton<DatabaseSubscription<Satislar>>();
            services.AddSingleton<DatabaseSubscription<Personeller>>();
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ChartsAPI", Version = "v1" });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ChartsAPI v1"));
            }
            app.UseDatabaseSubscription<DatabaseSubscription<Satislar>>("Satislar");
            app.UseDatabaseSubscription<DatabaseSubscription<Satislar>>("Personeller");
            app.UseCors();
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<SatisHub>("/satishub");
                endpoints.MapControllers();
            });
        }
    }
}
