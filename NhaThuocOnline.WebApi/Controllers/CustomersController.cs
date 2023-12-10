using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NhaThuocOnline.Application.Interfaces;
using NhaThuocOnline.Application.ViewModels.Customer;
using NhaThuocOnline.Utilities.Exceptions;
using NhaThuocOnline.ViewModel.Customer;

namespace NhaThuocOnline.WebApi.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomersController(ICustomerService customerService) {
            _customerService = customerService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCustomers()
        {
            var customers = await _customerService.GetCustomerPaging();
            return Ok(customers);
        }

        [HttpGet("{customerId}")]
        public async Task<IActionResult> GetCustomerById(int customerId)
        {
            var customer = await _customerService.GetCustomerById(customerId);

            if (customer == null)
            {
                return NotFound();
            }

            return Ok(customer);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromBody]RegisterRequest request)
        {

                if (!ModelState.IsValid)
                    return BadRequest(ModelState);
                var result = await _customerService.Register(request);
                if (result)
                    return Ok(result);

                return BadRequest(result); 
        }

        [HttpPut("{customerId}")]
        public async Task<IActionResult> UpdateCustomer(int customerId, CustomerUpdateRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var result = await _customerService.Update(customerId, request);
            if(result)
                return Ok(result);
            return BadRequest(result);

        }

        [HttpPatch("{customerId}/softdelete")]
        public async Task<IActionResult> SoftDeleteCustomer(int customerId)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var result = await _customerService.SoftDelete(customerId);
            if(result) 
                return Ok(result);
            return BadRequest();
        }

    


    }
}
    