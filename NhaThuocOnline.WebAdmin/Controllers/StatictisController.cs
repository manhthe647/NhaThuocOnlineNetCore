using Microsoft.AspNetCore.Mvc;

namespace NhaThuocOnline.WebAdmin.Controllers
{
    public class StatictisController : Controller
    {
        public IActionResult StockReport()
        {
            return View();
        }

        public IActionResult SalesReport()
        {
            return View();
        }
    }
}
