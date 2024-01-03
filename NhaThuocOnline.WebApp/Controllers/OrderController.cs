using Microsoft.AspNetCore.Mvc;
using NhaThuocOnline.Intergration;

namespace NhaThuocOnline.WebApp.Controllers
{
    public class OrderController : ClientBaseController
    {
        private readonly IOrderApiClient _orderApiClient;
        public OrderController(IOrderApiClient orderApiClient)
        {
            _orderApiClient = orderApiClient;
        }

        [HttpGet]
        public async Task<IActionResult> Checkout()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Checkout(string cartId)
        {

            var result = await _orderApiClient.GetProductByCartId(cartId);
            return RedirectToAction("Checkout","Order",result);
        }
    }
}
