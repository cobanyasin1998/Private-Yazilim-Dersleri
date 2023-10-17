using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Features.Queries.ProductImageFile.GetProductImages
{
    public class GetProductImagesResponse
    {
        public string FilePath { get;  set; }
        public string FileName { get;  set; }
        public Guid Id { get;  set; }
    }
}
