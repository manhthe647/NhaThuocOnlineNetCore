using Microsoft.AspNetCore.Mvc;
using NhaThuocOnline.ApiIntergration;
using NhaThuocOnline.ViewModel.Product;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;
using System.Drawing.Printing;

namespace NhaThuocOnline.WebAdmin.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductApiClient _productApiClient;
        public ProductController(IProductApiClient productApiClient)
        {
            _productApiClient = productApiClient;
        }
        public async Task<IActionResult> Index(string? keyword, string? orderBy, int? categoryId, int pageIndex = 1, int pageSize = 8)
        {
            var request = new GetManageProductPagingRequest()
            {
                Keyword = keyword,
                OrderBy = orderBy,
                PageIndex = pageIndex,
                PageSize = pageSize,
                CategoryId = categoryId
            };
            var result = await _productApiClient.GetAllProductsPaging(request);
            ViewBag.TotalRecords = result.TotalRecords;
            ViewBag.PageSize = result.PageSize;
            ViewBag.PageCount = result.PagedCount;
            ViewBag.PageIndex = result.PageIndex;
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
