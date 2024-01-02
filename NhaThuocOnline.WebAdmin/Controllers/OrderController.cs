using Microsoft.AspNetCore.Mvc;

namespace NhaThuocOnline.WebAdmin.Controllers
{
    public class OrderController : Controller
    {
        [HttpGet]

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddReturn()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Details()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ListReturn()
        {
            return View();
        }
    }
}
