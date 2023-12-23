using ETicaretAPI.Application.Features.Commands.Product.UpdateProduct;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Features.Commands.ProductImageFiles.UploadProductImage
{
    public class UploadProductImageRequest : IRequest<UploadProductImageResponse>
    {
        public string Id { get; set; }
        public IFormFileCollection? Files { get; set; }
    }
}
