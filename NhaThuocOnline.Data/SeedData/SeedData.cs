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
            modelBuilder.Entity<AppStaffAccount>().HasData(
        new AppStaffAccount
    {
        Id = 1,
        FirstName = "John",
        LastName = "Doe",
        Dob = new DateTime(1990, 10, 15),
        UserName = "johndoe",
        Password = "password123",
        Salt = "somesalt123",
        Email = "johndoe@example.com",
        Phone = "1234567890",
        Role = "admin",
        CreatedAt = DateTime.Now
    },
        new AppStaffAccount
    {
        Id = 2,
        FirstName = "Jane",
        LastName = "Smith",
        Dob = new DateTime(1995, 5, 20),
        UserName = "janesmith",
        Password = "pass4321",
        Salt = "somesalt456",
        Email = "janesmith@example.com",
        Phone = "9876543210",
        Role = "user",
        CreatedAt = DateTime.Now
    },
        new AppStaffAccount
        {
            Id = 3,
            FirstName = "Michael",
            LastName = "Johnson",
            Dob = new DateTime(1982, 3, 20),
            UserName = "michaeljohnson",
            Password = "qwerty123",
            Salt = "somesalt789",
            Email = "michaeljohnson@example.com",
            Phone = "5551234567",
            Role = "user",
            CreatedAt = DateTime.Now
        },
        new AppStaffAccount
        {
            Id = 4,
            FirstName = "Emily",
            LastName = "Davis",
            Dob = new DateTime(1995, 11, 5),
            UserName = "emilydavis",
            Password = "password456",
            Salt = "somesaltabc",
            Email = "emilydavis@example.com",
            Phone = "1112223333",
            Role = "user",
            CreatedAt = DateTime.Now
        },
        new AppStaffAccount
        {
            Id = 5,
            FirstName = "Andrew",
            LastName = "Wilson",
            Dob = new DateTime(1998, 7, 25),
            UserName = "andrewwilson",
            Password = "pass1234",
            Salt = "somesaltxyz",
            Email = "andrewwilson@example.com",
            Phone = "7778889999",
            Role = "admin",
            CreatedAt = DateTime.Now
        },
        new AppStaffAccount
        {
            Id = 6,
            FirstName = "Emma",
            LastName = "Brown",
            Dob = new DateTime(1989, 1, 15),
            UserName = "emmabrown",
            Password = "abc123",
            Salt = "somesalt789",
            Email = "emmabrown@example.com",
            Phone = "4445556666",
            Role = "user",
            CreatedAt = DateTime.Now
        }
  
);
            modelBuilder.Entity<AppStaffRole>().HasData(
      new AppStaffRole
      {
          Id = 1,
          Name = "Quản trị",
          Description = "Administrator role with full access"
      },
      new AppStaffRole
      {
          Id = 2,
          Name = "Nhân viên bán hàng",
          Description = "Standard user role with limited access"
      },
      new AppStaffRole
      {
          Id = 3,
          Name = "Dược sĩ",
          Description = "Tư vấn đơn thuốc"
      });
           

        
        }
    }
}
