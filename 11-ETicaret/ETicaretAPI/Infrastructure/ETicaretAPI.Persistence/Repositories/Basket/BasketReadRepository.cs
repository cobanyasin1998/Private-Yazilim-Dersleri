﻿using ETicaretAPI.Application.Repositories.Basket;
using ETicaretAPI.Application.Repositories.Customer;
using ETicaretAPI.Persistence.Contexts;

namespace ETicaretAPI.Persistence.Repositories.Basket
{
    public class BasketReadRepository : ReadRepository<ETicaretAPI.Domain.Entities.Basket>, IBasketReadRepository
    {
        public BasketReadRepository(ETicaretAPIDbContext context) : base(context)
        {
        }
    }
}
