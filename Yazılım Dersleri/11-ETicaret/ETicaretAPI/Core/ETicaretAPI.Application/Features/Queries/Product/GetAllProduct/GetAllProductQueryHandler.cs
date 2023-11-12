using ETicaretAPI.Application.ExtensionMethod;
using ETicaretAPI.Application.Repositories.Product;
using ETicaretAPI.Application.RequestParameters;
using ETicaretAPI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Features.Queries.Product.GetAllProduct
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQueryRequest, GetAllProductQueryResponse>
    {
        private readonly IProductReadRepository _productReadRepository;
        public GetAllProductQueryHandler(IProductReadRepository productReadRepository)
        {
            _productReadRepository = productReadRepository;
        }
        public async Task<GetAllProductQueryResponse> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
        {
            var query = _productReadRepository.GetAll(tracking: false);
            var products = query
                .Paginate(page: request.Page, pageSize: request.Size, orderBy: p => p.CreatedDate, descending: true)
                .Include(y => y.ProductImageFiles)
                .Select(p => new
                {
                    p.Id,
                    p.Name,
                    p.Stock,
                    p.Price,
                    p.CreatedDate,
                    p.UpdatedDate,
                    productImageFile =  p.ProductImageFiles.FirstOrDefault()
                });

            var totalCount = query.Count();

            return new GetAllProductQueryResponse()
            {
                TotalCount = totalCount,
                Products = products
            };
        }
    }
}
