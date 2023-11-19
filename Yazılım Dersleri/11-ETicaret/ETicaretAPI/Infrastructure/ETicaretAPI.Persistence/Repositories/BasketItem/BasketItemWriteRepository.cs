﻿using ETicaretAPI.Application.Repositories.BasketItem;
using ETicaretAPI.Application.Repositories.Customer;
using ETicaretAPI.Persistence.Contexts;

namespace ETicaretAPI.Persistence.Repositories.BasketItem
{
    public class BasketItemWriteRepository : WriteRepository<ETicaretAPI.Domain.Entities.BasketItem>, IBasketItemWriteRepository
    {
        public BasketItemWriteRepository(ETicaretAPIDbContext context) : base(context)
        {

        }
    }
}
