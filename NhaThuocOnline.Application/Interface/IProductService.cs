using NhaThuocOnline.ViewModel.Common;
using NhaThuocOnline.ViewModel.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.Application.Interface
{
    public interface IProductService
    {
        Task<int> Create(ProductCreateRequest request);

        //Task<int> Update(ProductUpdateRequest request);
        Task<bool> SoftDelete(int id);

        Task<PagedResult<ProductBasicVm>> GetAllByCategoryIdPaging(GetPublicProductPagingRequest request);

        Task<PagedResult<ProductVm>> GetAllProductsPaging (GetManageProductPagingRequest request);

        Task<ProductVm> GetProductById(int id);

        Task<ApiResult<bool>> CategoryAssign(int id, CategoryAssignRequest request);

    }
}
