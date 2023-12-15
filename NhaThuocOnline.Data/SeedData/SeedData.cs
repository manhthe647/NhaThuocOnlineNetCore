using Microsoft.EntityFrameworkCore;
using NhaThuocOnline.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.Data.SeedData
{
    public static class SeedData
    {
        public static void SeedDataGenerate(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(

                 new Customer()
                 {
                     Id = 1,
                     FirstName = "Tran",
                     LastName = "The",
                     PhoneNumber = "0987932132",
                     AvatarImagePath = "/img/default-avt",
                     Email = "abc@example.com",
                     PasswordHash = "Abcd@123",
                     IsActive = true,
                     CreatedAt = new DateTime()
                 },
                  new Customer()
                  {
                      Id = 2,

                      FirstName = "Hoang",
                      LastName = "Huynh",
                      PhoneNumber = "03456789",
                      AvatarImagePath = "/img/default-avt",
                      Email = "def@example.com",

                      PasswordHash = "Abcd@123",
                      IsActive = true,
                      CreatedAt = new DateTime()
                  }

                );

            // product
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id= 1,
                    ProductName = "Paracetamol 500mg",
                    SKU="SKU001",
                    RegularPrice= 48000,
                    DiscountPrice= 38000,
                    
                    Description="Paracetamol 500mg là một loại thuốc giảm đau và hạ sốt thông thường được sử dụng. Nó phù hợp để giảm đau nhẹ đến vừa và hạ sốt.",
                    ImagePath= "img/products/paracetamol500mg.jpg",
                    Brand = "Stada",
                    SeoTitle ="Paracetamol 500mg",
                    SeoAlias= "paracetamol-500mg",

                    Packaging= "Hộp 10 Vỉ x 10 Viên",
                    Origin= "Việt Nam",
                    Manufacturer= "STADA",
                    ProductionLocation= "Việt Nam",
                    Ingredients= "Paracetamol",


                    isPrescriptionRequired= false,
                    IsPublished= true,

                    CreatedAt = DateTime.Now,
                    UpdatedAt= DateTime.Now
                },
                 new Product()
                 {
                     Id = 2,
                     ProductName = "Ibuprofen 200mg",
                     SKU = "SKU002",
                     RegularPrice = 55000,
                     DiscountPrice = 45000,
                     Description = "Ibuprofen 200mg là một loại thuốc giảm đau, hạ sốt và chống viêm thông thường được sử dụng. Nó phù hợp để giảm đau nhẹ đến vừa, hạ sốt và giảm viêm.",
                     ImagePath = "img/products/ibuprofen200mg.jpg",
                     Brand = "Nadyphar",
                     SeoTitle = "Ibuprofen 200mg",
                     SeoAlias = "ibuprofen-200mg",
                     Packaging = "Hộp 20 Vỉ x 10 Viên",
                     Origin = "Việt Nam",
                     Manufacturer = "ABC Company",
                     ProductionLocation = "Việt Nam",
                     Ingredients = "Ibuprofen",
                     isPrescriptionRequired = false,
                     IsPublished = true,
                     CreatedAt = DateTime.Now,
                     UpdatedAt = DateTime.Now
                 }, 
                 new Product()
                 {
                     Id = 3,
                     ProductName = "Vitamin C 1000mg",
                     SKU = "SKU003",
                     RegularPrice = 25000,
                     DiscountPrice = 20000,
                     Description = "Vitamin C 1000mg là một loại vitamin tổng hợp thường được sử dụng để bổ sung nhu cầu vitamin C hàng ngày. Nó giúp tăng cường hệ miễn dịch và chống oxy hóa.",
                     ImagePath = "img/products/vitaminc1000mg.jpg",
                     Brand= "KUDOS",
                     SeoTitle = "Vitamin C 1000mg",
                     SeoAlias = "vitamin-c-1000mg",
                     Packaging = "Hộp 30 Viên",
                     Origin = "Mỹ",
                     Manufacturer = "ABC Company",
                     ProductionLocation = "Mỹ",
                     Ingredients = "Vitamin C",
                     isPrescriptionRequired = false,
                     IsPublished = true,
                     CreatedAt = DateTime.Now,
                     UpdatedAt = DateTime.Now
                 },
    new Product()
    {
        Id = 4,
        ProductName = "Omega-3 Fish Oil",
        SKU = "SKU004",
        RegularPrice = 120000,
        DiscountPrice = 100000,
        Description = "Omega-3 Fish Oil là một loại bổ sung dầu cá chứa các axit béo omega-3. Nó có lợi cho sức khỏe tim mạch, não bộ và khớp.",
        ImagePath = "img/products/omega3fishoil.jpg",
        Brand= "Sirio Pharma",
        SeoTitle = "Omega-3 Fish Oil",
        SeoAlias = "omega-3-fish-oil",
        Packaging = "Chai 60 Viên",
        Origin = "Na Uy",
        Manufacturer = "XYZ Company",
        ProductionLocation = "Na Uy",
        Ingredients = "Dầu cá omega-3",
        isPrescriptionRequired = false,
        IsPublished = true,
        CreatedAt = DateTime.Now,
        UpdatedAt = DateTime.Now
    }

                );

            modelBuilder.Entity<Category>().HasData(
                     new Category
                     {
                         Id = 1,
                         ParentId = 0,
                         CategoryName = "Dược phẩm",
                         CategoryDescription = "Dược phẩm",
                         ImagePath = "path/to/image",
                         IsActive = true,
                         CreatedAt = DateTime.Now,
                         UpdatedAt = DateTime.Now
                     },
    new Category
    {
        Id = 2,
        ParentId = 1,
        CategoryName = "Thuốc kê đơn",
        CategoryDescription = "Thuốc kê đơn",
        ImagePath = "path/to/image",
        IsActive = true,
        CreatedAt = DateTime.Now,
        UpdatedAt = DateTime.Now
    },
    new Category
    {
        Id = 3,
        ParentId = 1,
        CategoryName = "Thuốc không kê đơn",
        CategoryDescription = "Thuốc không kê đơn",
        ImagePath = "path/to/image",
        IsActive = true,
        CreatedAt = DateTime.Now,
        UpdatedAt = DateTime.Now
    },
    new Category
    {
        Id = 4,
        ParentId = 0,
        CategoryName = "Chăm sóc cá nhân",
        CategoryDescription = "Chăm sóc cá nhân",
        ImagePath = "path/to/image",
        IsActive = true,
        CreatedAt = DateTime.Now,
        UpdatedAt = DateTime.Now
    },
    new Category
    {
        Id = 5,
        ParentId = 4,
        CategoryName = "Khử mùi",
        CategoryDescription = "Khử mùi",
        ImagePath = "path/to/image",
        IsActive = true,
        CreatedAt = DateTime.Now,
        UpdatedAt = DateTime.Now
    },
    new Category
    {
        Id = 6,
        ParentId = 4,
        CategoryName = "Tóc",
        CategoryDescription = "Tóc",
        ImagePath = "path/to/image",
        IsActive = true,
        CreatedAt = DateTime.Now,
        UpdatedAt = DateTime.Now
    },
    new Category
    {
        Id = 7,
        ParentId = 4,
        CategoryName = "Răng miệng",
        CategoryDescription = "Răng miệng",
        ImagePath = "path/to/image",
        IsActive = true,
        CreatedAt = DateTime.Now,
        UpdatedAt = DateTime.Now
    },
    new Category
    {
        Id = 8,
        ParentId = 0,
        CategoryName = "Sản phẩm tiện lợi",
        CategoryDescription = "Sản phẩm tiện lợi",
        ImagePath = "path/to/image",
        IsActive = true,
        CreatedAt = DateTime.Now,
        UpdatedAt = DateTime.Now
    },
    new Category
    {
        Id = 9,
        ParentId = 8,
        CategoryName = "Hàng tổng hợp",
        CategoryDescription = "Hàng tổng hợp",
        ImagePath = "path/to/image",
        IsActive = true,
        CreatedAt = DateTime.Now,
        UpdatedAt = DateTime.Now
    }

                );
                      
         

        
        }
    }
}
