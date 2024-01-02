using Microsoft.AspNetCore.Mvc;
using NhaThuocOnline.ApiIntergration;
using NhaThuocOnline.ViewModel.Customer;

namespace NhaThuocOnline.WebAdmin.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerApiClient _customerApiClient;
        public CustomerController(ICustomerApiClient customerApiClient)
        {
            _customerApiClient = customerApiClient;
        }
        public async Task<IActionResult> Index()
        {
            var result = await _customerApiClient.GetCustomerPaging();
            return View(result);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var result = await _customerApiClient.GetCustomerById(id);
            return View(result);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var result = await _customerApiClient.GetCustomerById(id);
            if (result != null)
            {
                var customer = new CustomerUpdateRequest() {
                    CustomerId = id,
                    Email= result.Email,
                    FirstName = result.FirstName,
                    LastName = result.LastName,
                    PhoneNumber = result.PhoneNumber,
                    AvatarImagePath= "img/default-avt"
                };
                return View(customer);
            }
            return RedirectToAction("Error", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(CustomerUpdateRequest request)
        {
            if (!ModelState.IsValid)
                return View();

            bool result= await _customerApiClient.Update(request.CustomerId,request);
            if (result)
            {
            TempData["result"] = $"Cập nhật thông tin cho id {request.CustomerId} thành công !";
                return RedirectToAction("Index");
            }
            return View(request);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(new CustomerDeleteRequest()
            {
                Id = id
            });
        }

        [HttpPost]
        public async Task<IActionResult> Delete(CustomerDeleteRequest request)
        {
            if (!ModelState.IsValid)
                return View();
            bool result = await _customerApiClient.SoftDelete(request.Id);
            if (result)
            {
            TempData["result"] = $"Xóa tài khoản có id {request.Id} thành công !";
            return RedirectToAction("Index");

            }
            return View(request);

        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(RegisterRequest request)
        {
            if (!ModelState.IsValid)
                return View();
            bool result = await _customerApiClient.Register(request);
            if (result)
            {
            TempData["result"] = "Thêm tài khoản thành công";
                return RedirectToAction("Index");

            }
            return View(request);
        }


    }
}
