using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using NhaThuocOnline.Application.Interface;
using NhaThuocOnline.Application.ViewModels.Customer;
using NhaThuocOnline.Data.EF;
using NhaThuocOnline.Data.Entities;
using NhaThuocOnline.ViewModel.Common;
using NhaThuocOnline.ViewModel.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.Application.Service
{
    public class ProductService : IProductService
    {
        private readonly NhaThuocOnlineDbContext _dbContext;
        private const string USER_CONTENT_FOLDER_NAME = "user-content";
        private readonly IFileStorageService _storageService;
        public ProductService(NhaThuocOnlineDbContext dbContext, IFileStorageService storageService)
        {
            _dbContext = dbContext;
            _storageService = storageService;
        }

        public async Task<int> Create(ProductCreateRequest request)
        {
            var imagePath = "img/default-product";
            if(request.ImagePath!= null)
            {

                imagePath = await this.SaveFile(request.ImagePath);
            }

            var product = new Product() {
                ProductName = request.ProductName,
                SKU = request.SKU,
                RegularPrice = request.RegularPrice,
                DiscountPrice = request.DiscountPrice,
                Description = request.Description,
                Brand = request.Brand,
                Packaging = request.Packaging,
                Origin = request.Origin,
                Manufacturer = request.Manufacturer,
                ProductionLocation = request.ProductionLocation,
                Ingredients = request.Ingredients,
                SeoTitle = request.SeoTitle,
                SeoAlias = "product",
                isPrescriptionRequired =false,

                //isPrescriptionRequired = request.IsPrescriptionRequired,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                IsPublished = true,
                ImagePath = imagePath
            };
             await _dbContext.Products.AddAsync(product);
             await _dbContext.SaveChangesAsync();
            return product.Id;
        }

        public async Task<ProductVm> GetProductById(int id)
        {
            var product = await _dbContext.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (product != null)
            {
                var productVm = new ProductVm()
                {
                    Id = product.Id,
                    ProductName = product.ProductName,
                    RegularPrice = product.RegularPrice,
                    DiscountPrice = product.DiscountPrice,
                    Brand = product.Brand,

                    Description = product.Description,
                    Packaging = product.Packaging,
                    Origin = product.Origin,
                    Manufacturer = product.Manufacturer,
                    ProductionLocation = product.ProductionLocation,
                    Ingredients = product.Ingredients,

                    ImagePath = product.ImagePath,
                    SeoTitle = product.SeoTitle,
                    SeoAlias = product.SeoAlias,
                    isPrescriptionRequired = product.isPrescriptionRequired,

                };
                return productVm;
            }
            return new ProductVm();
        }

        public async Task<List<ProductBasicVm>> GetProductsPaging()
        {
            var productsVm = await _dbContext.Products.Select(x => new ProductBasicVm
            {
                Id = x.Id,
                ProductName = x.ProductName,
                RegularPrice = x.RegularPrice,
                DiscountPrice = x.DiscountPrice,
                isPrescriptionRequired = x.isPrescriptionRequired,

            }).ToListAsync();
            return new List<ProductBasicVm>(productsVm);
        }

        public Task<List<ProductBasicVm>> Search(SearchParams param)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SoftDelete(int id)
        {
            throw new NotImplementedException();
        }


        private async Task<string> SaveFile(IFormFile file)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
            await _storageService.SaveFileAsync(file.OpenReadStream(), fileName);
            return fileName;
        }
    }
}
