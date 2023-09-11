using ETicaretAPI.Application.Repositories.Product;
using ETicaretAPI.Persistence.Contexts;

namespace ETicaretAPI.Persistence.Repositories.Product
{


    public class ProductWriteRepository : WriteRepository<ETicaretAPI.Domain.Entities.Product>, IProductWriteRepository
    {
        public ProductWriteRepository(ETicaretAPIDbContext context) : base(context)
        {

        }
    }
}
