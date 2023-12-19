using NhaThuocOnline.ViewModel.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.Application.Interface
{
    public interface ICategoryService
    {
        Task<bool> CreateCategory(CategoryCreateRequest request);
        Task<List<CategoryVm>> GetAllCategories();

    }
}
