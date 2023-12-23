using ETicaretAPI.Application.Features.Commands.ProductImageFiles.UploadProductImage;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Features.Queries.ProductImageFile.GetProductImages
{
    public class GetProductImagesRequest : IRequest<List<GetProductImagesResponse>>
    {
        public string Id { get; set; }
    }
}
