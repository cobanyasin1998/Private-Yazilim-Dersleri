using ETicaretAPI.Application.Repositories.BasketItem;
using ETicaretAPI.Application.Repositories.Customer;
using ETicaretAPI.Persistence.Contexts;

namespace ETicaretAPI.Persistence.Repositories.BasketItem
{
    public class BasketItemReadRepository : ReadRepository<ETicaretAPI.Domain.Entities.BasketItem>, IBasketItemReadRepository
    {
        public BasketItemReadRepository(ETicaretAPIDbContext context) : base(context)
        {
        }
    }
}
