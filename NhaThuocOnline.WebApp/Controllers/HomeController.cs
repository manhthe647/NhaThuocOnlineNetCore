using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EShopSolution.WebAppMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }

        public IActionResult Checkout()
        {
            return View();
        }

    

        public IActionResult Prescriptions()
        {
            return View();
        }

      
        public IActionResult ProductDetails()
        {
            return View();
        }

        public IActionResult Store()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

     
    }
}