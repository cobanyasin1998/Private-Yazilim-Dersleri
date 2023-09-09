using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
        {
            return new(){
                new () {
                    Id = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    Name = "Telefon",
                    Price = 12,
                    Stock = 10
                }
            };
        }
    }
}
