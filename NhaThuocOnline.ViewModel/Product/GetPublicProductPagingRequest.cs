using NhaThuocOnline.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.ViewModel.Product
{
    public class GetPublicProductPagingRequest: PagingRequestBase
    {
        public int? CategoryId { get; set; }
        public string? Keyword { get; set; }
        public string? OrderBy { get; set; }
    }
}
