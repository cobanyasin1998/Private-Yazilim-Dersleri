using ETicaretAPI.Application.Repositories.Customer;
using ETicaretAPI.Persistence.Contexts;

namespace ETicaretAPI.Persistence.Repositories.Customer
{
    public class CustomerWriteRepository : WriteRepository<ETicaretAPI.Domain.Entities.Customer>, ICustomerWriteRepository
    {
        public CustomerWriteRepository(ETicaretAPIDbContext context) : base(context)
        {

        }
    }
}
