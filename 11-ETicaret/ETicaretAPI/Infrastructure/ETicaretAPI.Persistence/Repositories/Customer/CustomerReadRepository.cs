using ETicaretAPI.Application.Repositories.Customer;
using ETicaretAPI.Persistence.Contexts;

namespace ETicaretAPI.Persistence.Repositories.Customer
{
    public class CustomerReadRepository : ReadRepository<ETicaretAPI.Domain.Entities.Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(ETicaretAPIDbContext context) : base(context)
        {
        }
    }
}
