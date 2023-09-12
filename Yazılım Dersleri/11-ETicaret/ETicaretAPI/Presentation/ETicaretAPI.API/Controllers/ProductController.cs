using ETicaretAPI.Application.Repositories.Product;
using ETicaretAPI.Persistence.Repositories.Product;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        readonly private IProductWriteRepository _productWriteRepository;
        readonly private IProductReadRepository _productReadRepository;

        public ProductController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            await _productWriteRepository.AddAsync(new()
            {
                Name = "name",
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now.ToUniversalTime(),
                Price = 1,
                Stock = 2

            });
            await _productWriteRepository.SaveAsync();

            var data = _productReadRepository.GetAll(tracking: false);

            return Ok(data.ToList());
        }




    }
}
