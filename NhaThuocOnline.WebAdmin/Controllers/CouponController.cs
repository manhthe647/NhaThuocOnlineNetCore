using Microsoft.AspNetCore.Mvc;
using NhaThuocOnline.ApiIntergration;

namespace NhaThuocOnline.WebAdmin.Controllers
{
    public class CouponController : Controller
    {
        private readonly ICouponApiClient _couponApiClient;
        public CouponController(ICouponApiClient couponApiClient)
        {
            _couponApiClient = couponApiClient;
        }

        public async Task<IActionResult> Index()
        {
            var result= await _couponApiClient.GetAllCouponList();
            return View(result);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
    }
}
