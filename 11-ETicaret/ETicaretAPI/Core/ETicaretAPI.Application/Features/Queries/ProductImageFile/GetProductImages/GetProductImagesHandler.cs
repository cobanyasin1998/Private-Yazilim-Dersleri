using ETicaretAPI.Application.Features.Commands.Product.UpdateProduct;
using ETicaretAPI.Application.Repositories.Product;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Features.Queries.ProductImageFile.GetProductImages
{
    public class GetProductImagesHandler : IRequestHandler<GetProductImagesRequest, List<GetProductImagesResponse>>
    {
        private readonly IProductReadRepository _productReadRepository;
        private readonly IConfiguration _configuration;

        public async Task<List<GetProductImagesResponse>> Handle(GetProductImagesRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Product? product = await _productReadRepository.Table.Include(p => p.ProductImageFiles).FirstOrDefaultAsync(p => p.Id == Guid.Parse(request.Id));

            return  product.ProductImageFiles.Select(y => new GetProductImagesResponse
            {
                FilePath = $"{_configuration["BaseStorageUrl"]}/{y.FilePath}",
                FileName =  y.FileName,
                Id = y.Id
            }).ToList();
         
        }
    }
}
