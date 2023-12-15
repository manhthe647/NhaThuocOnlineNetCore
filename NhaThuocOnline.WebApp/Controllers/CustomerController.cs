using Microsoft.AspNetCore.Mvc;

namespace NhaThuocOnline.WebApp.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }
    }
}
