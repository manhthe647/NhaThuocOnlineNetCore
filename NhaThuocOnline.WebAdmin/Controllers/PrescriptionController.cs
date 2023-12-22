using Microsoft.AspNetCore.Mvc;
using NhaThuocOnline.ApiIntergration;

namespace NhaThuocOnline.WebAdmin.Controllers
{
    public class PrescriptionController: Controller
    {
        private readonly IPrescriptionApiClient _prescriptionApiClient;
        public PrescriptionController(IPrescriptionApiClient prescriptionApiClient)
        {
          _prescriptionApiClient = prescriptionApiClient;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _prescriptionApiClient.GetAll();
            return View(result);
        }
    }
}
