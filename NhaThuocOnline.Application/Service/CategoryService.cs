using Microsoft.EntityFrameworkCore;
using NhaThuocOnline.Application.Interface;
using NhaThuocOnline.Data.EF;
using NhaThuocOnline.Data.Entities;
using NhaThuocOnline.ViewModel.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.Application.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly NhaThuocOnlineDbContext _dbContext;
        public CategoryService(NhaThuocOnlineDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<bool> CreateCategory(CategoryCreateRequest request)
        {

        var newCategory = new Category()
            {
                ParentId = request.ParentId,
                CategoryName = request.CategoryName,
                CategoryDescription = request.CategoryDescription,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                ImagePath = "img/default-category.img",
                IsActive = true,
                
            };
          _dbContext.Categories.Add(newCategory);
            await _dbContext.SaveChangesAsync();
         return true;
            
        }

        public async Task<List<CategoryVm>> GetAllCategories()
        {
            var data= await _dbContext.Categories.Select(x=> new CategoryVm
            {
                 Id = x.Id,
                 ParentId = x.ParentId,
                CategoryName = x.CategoryName,
                CategoryDescription = x.CategoryDescription,
                ImagePath= x.ImagePath,
                 IsActive= x.IsActive,
            }).ToListAsync();

            return new List<CategoryVm>(data);
        }
    }
}
