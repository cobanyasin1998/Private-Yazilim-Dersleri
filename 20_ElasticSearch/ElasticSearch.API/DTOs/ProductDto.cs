using ElasticSearch.API.Models;
using Nest;

namespace ElasticSearch.API.DTOs
{
    public record ProductDto
    {
       
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

        public ProductFeature? Feature { get; set; }
    }
}
