using NhaThuocOnline.ViewModel.Common;
using NhaThuocOnline.ViewModel.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.ApiIntergration
{
    public interface IProductApiClient
    {

        Task<bool> Create(ProductCreateRequest request);

        Task<PagedResult<ProductBasicVm>> GetProductsPaging(GetPublicProductPagingRequest request);
        Task<ProductVm> GetProductById(int id);

        //Task<bool> Update(int id, ProductUpdateRequest request);
        Task<bool> SoftDelete(int id);
    }
}
