using Microsoft.AspNetCore.Mvc;
using NhaThuocOnline.ApiIntergration;

namespace NhaThuocOnline.WebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductApiClient _productApiClient;
        public ProductController(IProductApiClient productApiClient)
        {
            _productApiClient = productApiClient;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _productApiClient.GetProductsPaging();
            return View(result);
        }


        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var result = await _productApiClient.GetProductById(id);
            return View(result);
        }

        public IActionResult Search()
        {
            return View();
        }
    }
}
