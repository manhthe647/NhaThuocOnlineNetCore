using Microsoft.AspNetCore.Mvc;
using NhaThuocOnline.ApiIntergration;
using NhaThuocOnline.Application.ViewModels.Customer;
using NhaThuocOnline.ViewModel.Product;

namespace NhaThuocOnline.WebAdmin.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductApiClient _productApiClient;
        public ProductController(IProductApiClient productApiClient)
        {
            _productApiClient = productApiClient;
        }
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

  

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductCreateRequest request)
        {
            if (!ModelState.IsValid)
                return View();
            bool result = await _productApiClient.Create(request);
            if (result)
            {
                TempData["result"] = "Thêm sản phẩm thành công";
                return RedirectToAction("Index");

            }
            return View(request);
        }
    }
}
