using NhaThuocOnline.ViewModel.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.ApiIntergration
{
    public interface ICategoryApiClient
    {
        Task<bool> CreateCategory(CategoryCreateRequest request);
        Task<List<CategoryVm>> GetAllCategories();
    }
}
