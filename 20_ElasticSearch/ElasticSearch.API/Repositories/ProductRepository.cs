using ElasticSearch.API.DTOs;
using ElasticSearch.API.Models;
using Nest;
using System.Collections.Immutable;

namespace ElasticSearch.API.Repositories
{
    public class ProductRepository
    {
        private readonly IElasticClient _elasticClient;
        private const string INDEX_NAME = "products";
        public ProductRepository(IElasticClient elasticClient)
        {
            _elasticClient = elasticClient;
        }

        public async Task<Product?> SaveAsync(Product newProduct)
        {
            newProduct.Created = DateTime.Now;
            var response = await _elasticClient.IndexAsync(newProduct, x => x.Index(INDEX_NAME).Id(Guid.NewGuid().ToString()));

            if (!response.IsValid) return null;//Fast Fail

            newProduct.Id = response.Id;
            return newProduct;
        }
        public async Task<ImmutableList<Product>> GetAllAsync()
        {
            var response = await _elasticClient.SearchAsync<Product>(x => x.Index(INDEX_NAME).Query(q => q.MatchAll()));

            foreach (var hit in response.Hits) hit.Source.Id = hit.Id;


            return response.Documents.ToImmutableList();
        }
        public async Task<Product?> GetByIdAsync(string id)
        {
            var response = await _elasticClient.GetAsync<Product>(id, x => x.Index(INDEX_NAME));

            if (!response.IsValid) return null;

            response.Source.Id = response.Id;
            return response.Source;
        }
        public async Task<bool> UpdateAsync(Product product)
        {
            var response = await _elasticClient.UpdateAsync<Product>(product.Id, x => x.Index(INDEX_NAME).Doc(product));

            return response.IsValid;
        }
        public async Task<DeleteResponse> DeleteAsync(string id)
        {
            var response = await _elasticClient.DeleteAsync<Product>(id, x => x.Index(INDEX_NAME));

            return response;
        }
    }
}
