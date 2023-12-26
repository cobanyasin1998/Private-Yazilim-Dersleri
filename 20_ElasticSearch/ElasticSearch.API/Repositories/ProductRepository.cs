﻿using ElasticSearch.API.Models;
using Nest;

namespace ElasticSearch.API.Repositories
{
    public class ProductRepository
    {
        private readonly ElasticClient _elasticClient;
        public ProductRepository(ElasticClient elasticClient)
        {
            _elasticClient = elasticClient;
        }

        public async Task<Product?> SaveAsync(Product newProduct)
        {
            newProduct.Created = DateTime.Now;
            var response = await _elasticClient.IndexAsync(newProduct, x => x.Index("products"));

            if (!response.IsValid) return null;//Fast Fail

            newProduct.Id = response.Id;
            return newProduct;
        }
    }
}
