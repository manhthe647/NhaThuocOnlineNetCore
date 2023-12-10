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

                ); ; ;
                      
         

        
        }
    }
}
