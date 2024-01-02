using Microsoft.AspNetCore.Mvc;

namespace NhaThuocOnline.WebApp.Controllers
{
    public class OrderController : ClientBaseController
    {
        public IActionResult Checkout()
        {
            return View();
        }
    }
}
