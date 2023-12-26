using Elasticsearch.Net;
using Nest;

namespace ElasticSearch.API.Extensions
{
    public static class ElasticSearchServiceExtension
    {
        public static void AddElasticSearchClient(this IServiceCollection services, IConfiguration configuration)
        {
            var uri = new Uri(configuration.GetSection("Elastic")["Url"]!);
            var pool = new SingleNodeConnectionPool(uri);

            var settings = new ConnectionSettings(pool)
                .RequestTimeout(TimeSpan.FromMinutes(5));

            var client = new ElasticClient(settings);

            services.AddSingleton<IElasticClient>(client);
        }
    }
  
}
