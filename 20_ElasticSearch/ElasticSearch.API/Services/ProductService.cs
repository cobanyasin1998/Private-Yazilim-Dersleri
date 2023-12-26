﻿using ElasticSearch.API.DTOs;
using ElasticSearch.API.Models;
using ElasticSearch.API.Repositories;
using System.Net;

namespace ElasticSearch.API.Services
{
    public class ProductService
    {
        private readonly ProductRepository _productRepository;

        public ProductService(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<ResponseDto<ProductDto>?> SaveAsync(ProductCreateDto request)
        {


            var responseProduct = await _productRepository.SaveAsync(request.ToProduct());

            if (responseProduct is null)
            {
                return ResponseDto<ProductDto>.Fail(
                   new List<string> { "Kayıt Esnasında Bir Hata Meydana Geldi" },
                    HttpStatusCode.InternalServerError);
            }
            return ResponseDto<ProductDto>.Success(responseProduct.ToProductDto(), HttpStatusCode.OK);

        }
    }
}
