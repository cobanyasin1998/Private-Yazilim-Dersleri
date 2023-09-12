using ETicaretAPI.Application.Repositories.Customer;
using ETicaretAPI.Application.Repositories.Order;
using ETicaretAPI.Application.Repositories.Product;
using ETicaretAPI.Persistence.Contexts;
using ETicaretAPI.Persistence.Repositories.Customer;
using ETicaretAPI.Persistence.Repositories.Order;
using ETicaretAPI.Persistence.Repositories.Product;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ETicaretAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<ETicaretAPIDbContext>(opt =>
            {

                opt.UseNpgsql(Configuration.ConnectionString);

            });

            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();

            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
                
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
        }
    }
}
