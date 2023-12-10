using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NhaThuocOnline.Application.Interfaces;
using NhaThuocOnline.Application.ViewModels.Customer;
using NhaThuocOnline.Data.EF;
using NhaThuocOnline.Data.Entities;
using NhaThuocOnline.Utilities.Exceptions;
using NhaThuocOnline.ViewModel.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.Application.Implementation
{
    public class CustomerService : ICustomerService
    {
        private readonly NhaThuocOnlineDbContext _dbContext;

        public CustomerService(NhaThuocOnlineDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<string> Authencate(LoginRequest request)
        {
            return "a";
        }

        public async Task<bool> SoftDelete(int id)
        {
            var customer = await _dbContext.Customers.SingleOrDefaultAsync(x => x.Id == id);
            if (customer != null)
            {
               
                customer.IsActive=false;
                await _dbContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<CustomerVm> GetCustomerById(int id)
        {
           
            var customer = _dbContext.Customers.FirstOrDefault(x => x.Id == id);
            if (customer != null)
            {
                var result = new CustomerVm()
                {
                    Id = id,
                    FirstName = customer.FirstName,
                    LastName = customer.LastName,
                    Email = customer.Email,
                    PhoneNumber = customer.PhoneNumber,
                    IsActive = customer.IsActive

                };
                return result;
            }
             return new CustomerVm();

        }

        public async Task<List<CustomerVm>> GetCustomerPaging()
        {
           var customersVm= await _dbContext.Customers.Select(x=> new CustomerVm
           {
               Id = x.Id,
               FirstName=x.FirstName,
               LastName=x.LastName,
               Email = x.Email,
               PhoneNumber = x.PhoneNumber,
               IsActive = x.IsActive

           }).ToListAsync();
            return new List<CustomerVm>(customersVm);
        }
        public async Task<bool> Update(int id,CustomerUpdateRequest request)
        {
            var hasCustomer= await _dbContext.Customers.AnyAsync(x=>x.Email== request.Email && x.Id==id);
            if (!hasCustomer)
            {
                return false;
            }

            var customer = await _dbContext.Customers.FindAsync(id);
            if (customer != null)
            {
                customer.Id = id;
                customer.Email = request.Email;
                customer.FirstName = request.FirstName;
                customer.LastName = request.LastName;
                customer.PhoneNumber= request.PhoneNumber;
                customer.AvatarImagePath = request.AvatarImagePath;
                 await _dbContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<bool> Register(RegisterRequest request)
        {
            var existingCustomer = await _dbContext.Customers.FirstOrDefaultAsync(c => c.Email == request.Email);
            if (existingCustomer != null)
            {
                return false; // Khách hàng đã tồn tại
            }

            if (request.Password != request.ConfirmPassword)
            {
                return false; // Mật khẩu và xác nhận mật khẩu không khớp
            }

            var passwordHash = HashPassword(request.Password);

            var customerAccount = new Customer()
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                PasswordHash = passwordHash,
                AvatarImagePath = "/img/default-avt",
                PhoneNumber = "chưa thêm",
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            };

            _dbContext.Customers.Add(customerAccount);
            await _dbContext.SaveChangesAsync();

            return true; // Đăng ký thành công
        }

        private string HashPassword(string password)
        {
            using (SHA256 hash = SHA256.Create())
            {
                var pwdBytes = Encoding.UTF8.GetBytes(password);
                var hashedPwd = hash.ComputeHash(pwdBytes);
                return Convert.ToHexString(hashedPwd);
            }
        }


    }
}
