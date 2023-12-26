using ElasticSearch.API.DTOs;
using ElasticSearch.API.Models;
using ElasticSearch.API.Repositories;

namespace ElasticSearch.API.Services
{
    public class ProductService
    {
        private readonly ProductRepository _productRepository;

        public ProductService(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Product?> SaveAsync(ProductCreateDto request)
        {


            var response = await _productRepository.SaveAsync(request.ToProduct());

            if (response is null)
            {
                return ResponseDto<ProducTCr>
            }

        }
    }
}
