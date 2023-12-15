using NhaThuocOnline.Application.ViewModels.Customer;
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

        Task<List<ProductBasicVm>> GetProductsPaging();

        Task<List<ProductBasicVm>> Search(SearchParams param);

        Task<ProductVm> GetProductById(int id);

        //Task<bool> Update(int id, ProductUpdateRequest request);
        Task<bool> SoftDelete(int id);
    }
}
