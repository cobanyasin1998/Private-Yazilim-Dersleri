using ETicaretAPI.Application.Features.Commands.ProductImageFiles.UploadProductImage;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Features.Commands.ProductImageFiles.RemoveProductImage
{
    public class RemoveProductImageRequest : IRequest<RemoveProductImageResponse>
    {
        public string? Id { get; set; }
        public string? ImageId { get; set; }
    }
}
