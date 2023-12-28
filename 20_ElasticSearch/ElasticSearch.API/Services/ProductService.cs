using ElasticSearch.API.DTOs;
using ElasticSearch.API.Models;
using ElasticSearch.API.Repositories;
using System.Collections.Immutable;
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
        public async Task<ResponseDto<ImmutableList<ProductDto>>?> GetAllAsync()
        {
            var responseProducts = await _productRepository.GetAllAsync();

            if (responseProducts is null)
            {
                return ResponseDto<ImmutableList<ProductDto>>.Fail(
                                      new List<string> { "Getirme Esnasında Bir Hata Meydana Geldi" },
                                                         HttpStatusCode.InternalServerError);
            }

            var data = responseProducts.Select(x =>
                new ProductDto(x.Id, x.Name, x.Price, x.Stock,
                x.Feature != null ? new ProductFeatureDto(x.Feature.Width, x.Feature.Height, x.Feature.Color) : null))
                .ToImmutableList();


            return ResponseDto<ImmutableList<ProductDto>>.Success(data, HttpStatusCode.OK);

        }
        public async Task<ResponseDto<ProductDto>?> GetByIdAsync(string id)
        {
            var responseProduct = await _productRepository.GetByIdAsync(id);

            if (responseProduct is null)
            {
                return ResponseDto<ProductDto>.Fail(
                                      new List<string> { "Getirme Esnasında Bir Hata Meydana Geldi" },
                                                         HttpStatusCode.InternalServerError);
            }
            return ResponseDto<ProductDto>.Success(responseProduct.ToProductDto(), HttpStatusCode.OK);
        }
        public async Task<ResponseDto<bool>?> UpdateAsync(ProductUpdateDto request)
        {
            var product = await _productRepository.UpdateAsync(request.ToProduct());

            if (product != true)
            {
                return ResponseDto<bool>.Fail(
                                                         new List<string> { "Güncelleme Esnasında Bir Hata Meydana Geldi" },
                                                                                                                 HttpStatusCode.InternalServerError);
            }



            return ResponseDto<bool>.Success(true, HttpStatusCode.OK);
        }
        public async Task<ResponseDto<bool>?> DeleteAsync(string id)
        {
            var deleteResponse = await _productRepository.DeleteAsync(id);

            if (!deleteResponse.IsValid && deleteResponse.Result == Nest.Result.NotFound)
            {
                return ResponseDto<bool>.Fail(
                  new List<string> { "Silmeye Çalıştığınız Ürün Bulunamadı" },
                  HttpStatusCode.InternalServerError);
            }
            if (!deleteResponse.IsValid)
            {
                return ResponseDto<bool>.Fail(
                   new List<string> { "Silme Esnasında Bir Hata Meydana Geldi" },
                   HttpStatusCode.InternalServerError);
            }
           
            return ResponseDto<bool>.Success(true, HttpStatusCode.OK);

        }
    }
}
