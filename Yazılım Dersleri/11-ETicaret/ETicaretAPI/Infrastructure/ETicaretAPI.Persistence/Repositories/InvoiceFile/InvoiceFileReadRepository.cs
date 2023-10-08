using ETicaretAPI.Application.Repositories.Customer;
using ETicaretAPI.Application.Repositories.InvoiceFile;
using ETicaretAPI.Persistence.Contexts;

namespace ETicaretAPI.Persistence.Repositories.Customer
{
    public class InvoiceFileReadRepository : ReadRepository<ETicaretAPI.Domain.Entities.InvoiceFile>, IInvoiceFileReadRepository
    {
        public InvoiceFileReadRepository(ETicaretAPIDbContext context) : base(context)
        {
        }
    }
}
