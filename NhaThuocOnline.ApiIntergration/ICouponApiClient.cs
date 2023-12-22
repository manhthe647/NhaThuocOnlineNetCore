using NhaThuocOnline.ViewModel.Coupon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.ApiIntergration
{
    public interface ICouponApiClient
    {
        Task<bool> CreateCouponCode(CouponCreateRequest request);
        Task<List<CouponVm>> GetAllCouponList();
    }
}
