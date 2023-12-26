﻿using ElasticSearch.API.Models;

namespace ElasticSearch.API.DTOs
{
    public record ProductCreateDto(
        string Name,
        decimal Price,
        int Stock,
        ProductFeatureDto Feature)
    {



        public Product ToProduct()
        {
            return new Product
            {
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
