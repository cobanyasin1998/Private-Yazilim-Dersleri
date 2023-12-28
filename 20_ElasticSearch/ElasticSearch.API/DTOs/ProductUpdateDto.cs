using ElasticSearch.API.Models;

namespace ElasticSearch.API.DTOs
{
    public record ProductUpdateDto(
        string Id,
         string Name,
         decimal Price,
         int Stock,
         ProductFeatureDto Feature)
    {



        public Product ToProduct()
        {
            return new Product
            {
                Id = Id,
                Name = Name,
                Price = Price,
                Stock = Stock,
                Feature = new ProductFeature
                {
                    Width = Feature.Width,
                    Height = Feature.Height,
                    Color = Feature.Color
                }
            };
        }
    }
}
