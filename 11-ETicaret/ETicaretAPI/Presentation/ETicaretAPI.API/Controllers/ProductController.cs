using ETicaretAPI.Application.Features.Commands.Product.CreateProduct;
using ETicaretAPI.Application.Features.Commands.Product.RemoveProduct;
using ETicaretAPI.Application.Features.Commands.Product.UpdateProduct;
using ETicaretAPI.Application.Features.Commands.ProductImageFiles.RemoveProductImage;
using ETicaretAPI.Application.Features.Commands.ProductImageFiles.UploadProductImage;
using ETicaretAPI.Application.Features.Queries.Product.GetAllProduct;
using ETicaretAPI.Application.Features.Queries.Product.GetByIdProduct;
using ETicaretAPI.Application.Features.Queries.ProductImageFile.GetProductImages;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]   
    [ApiController]

    public class ProductController : ControllerBase
    {

        private readonly IMediator _mediator;

        public ProductController(

            IMediator mediator)
        {

            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult> Get([FromQuery] GetAllProductQueryRequest getAllProductQueryRequest)
        {

            GetAllProductQueryResponse response = await _mediator.Send(getAllProductQueryRequest);
            return Ok(response);

        }

        [HttpGet("{Id}")]
        public async Task<ActionResult> Get(GetByIdProductQueryRequest getByIdProductQueryRequest)
        {
            GetByIdProductQueryResponse response = await _mediator.Send(getByIdProductQueryRequest);
            return Ok(response);

        }

        [HttpPost]
        [Authorize(AuthenticationSchemes = "Admin")]
        public async Task<IActionResult> Post(CreateProductCommandRequest createProductCommandRequest)
        {
            CreateProductCommandResponse createProductCommandResponse = await _mediator.Send(createProductCommandRequest);
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpPut]
        [Authorize(AuthenticationSchemes = "Admin")]

        public async Task<IActionResult> Put([FromBody] UpdateProductCommandRequest updateProductCommandRequest)
        {
            UpdateProductCommandResponse updateProductCommandResponse = await _mediator.Send(updateProductCommandRequest);

            return StatusCode((int)HttpStatusCode.OK);
        }

        [HttpDelete("{Id}")]
        [Authorize(AuthenticationSchemes = "Admin")]

        public async Task<IActionResult> Delete([FromRoute] RemoveProductCommandRequest removeProductCommandRequest)
        {
            RemoveProductCommandResponse removeProductCommandResponse = await _mediator.Send(removeProductCommandRequest);
            return Ok();
        }

        [HttpPost("[action]")]
        [Authorize(AuthenticationSchemes = "Admin")]

        [RequestFormLimits(ValueLengthLimit = int.MaxValue, MultipartBodyLengthLimit = int.MaxValue)]
        public async Task<IActionResult> Upload([FromQuery, FromForm] UploadProductImageRequest uploadProductImageRequest)
        {
            uploadProductImageRequest.Files = Request.Form.Files;

            UploadProductImageResponse removeProductCommandResponse = await _mediator.Send(uploadProductImageRequest);

            return Ok();

        }


        [HttpGet("[action]/{Id}")]
        [Authorize(AuthenticationSchemes = "Admin")]

        public async Task<IActionResult> GetProductImages(GetProductImagesRequest getProductImagesRequest)
        {
            List<GetProductImagesResponse> removeProductCommandResponse = await _mediator.Send(getProductImagesRequest);
            return Ok(removeProductCommandResponse);

        }

        [HttpDelete("[action]/{Id}")]
        [Authorize(AuthenticationSchemes = "Admin")]

        public async Task<IActionResult> DeleteProductImage([FromRoute] RemoveProductImageRequest removeProductImageRequest, [FromQuery] string imageId)
        {
            removeProductImageRequest.ImageId = imageId;
            RemoveProductImageResponse removeProductImageResponse = await _mediator.Send(removeProductImageRequest);
            return Ok();
        }
    }
}