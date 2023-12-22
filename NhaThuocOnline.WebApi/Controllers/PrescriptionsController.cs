using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NhaThuocOnline.Application.Interface;
using NhaThuocOnline.ViewModel.Category;
using NhaThuocOnline.ViewModel.Prescription;

namespace NhaThuocOnline.WebApi.Controllers
{
    [Route("api/prescriptions")]
    [ApiController]
    public class PrescriptionsController: ControllerBase
    {
        private readonly IPrescriptionService _prescriptionService;
        public PrescriptionsController(IPrescriptionService prescriptionService)
        {
            _prescriptionService = prescriptionService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await _prescriptionService.GetAll();
            return Ok(data);
        }

        [HttpPost]
        [Consumes("multipart/form-data")]

        public async Task<IActionResult> Create([FromForm] PrescriptionCreateRequest request)
        {

            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var result = await _prescriptionService.Create(request);
            if (result)
                return Ok(result);

            return BadRequest(result);
        }
    }
}
