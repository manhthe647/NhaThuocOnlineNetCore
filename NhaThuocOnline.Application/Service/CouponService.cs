using Microsoft.EntityFrameworkCore;
using NhaThuocOnline.Application.Interface;
using NhaThuocOnline.Data.EF;
using NhaThuocOnline.Data.Entities;
using NhaThuocOnline.ViewModel.Category;
using NhaThuocOnline.ViewModel.Coupon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.Application.Service
{
    public class CouponService: ICouponService
    {
        private readonly NhaThuocOnlineDbContext _dbContext;
        public CouponService(NhaThuocOnlineDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<bool> CreateCouponCode(CouponCreateRequest request)
        {

            var newCoupon = new Coupon()
            {
                Code = request.Code,
                CouponDescription = request.CouponDescription,
                TimesUsed = 0,
                MaxUsage = request.MaxUsage,
                CouponStartDate = request.CouponStartDate,
                CouponEndDate = request.CouponEndDate,
                DiscountType = request.DiscountType,
                DiscountValue = request.DiscountValue,
                IsActive = true,
                CreatedAt = DateTime.Now,
               UpdatedAt = DateTime.Now,

            };
            _dbContext.Coupons.Add(newCoupon);
            await _dbContext.SaveChangesAsync();
            return true;

        }

        public async Task<List<CouponVm>> GetAllCouponList()
        {
            var data = await _dbContext.Coupons.Select(x => new CouponVm
            {
               Id = x.Id,
               Code = x.Code,
               TimesUsed = x.TimesUsed,
               MaxUsage = x.MaxUsage,
               DiscountType= x.DiscountType,
               DiscountValue= x.DiscountValue,
               IsActive= x.IsActive,
                CouponDescription = x.CouponDescription,
                CouponStartDate= x.CouponStartDate,
                CouponEndDate = x.CouponEndDate
                
            }).ToListAsync();

            return new List<CouponVm>(data);
        }
    }
}
