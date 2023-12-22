using Microsoft.AspNetCore.Mvc;
using NhaThuocOnline.ApiIntergration;

namespace NhaThuocOnline.WebAdmin.Controllers
{
    public class CategoryController: Controller
    {
        private readonly ICategoryApiClient _categoryApiClient;
        public CategoryController(ICategoryApiClient categoryApiClient)
        {
            _categoryApiClient = categoryApiClient;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _categoryApiClient.GetAllCategories();
            return View(result);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
    }
}
