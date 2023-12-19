using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NhaThuocOnline.Application.Interface;
using NhaThuocOnline.Application.Service;
using NhaThuocOnline.ViewModel.Cart;

namespace NhaThuocOnline.WebApi.Controllers
{
    [Route("api/carts")]
    [ApiController]
    public class CartsController : ControllerBase
    {
        private readonly ICartService _cartService;
        public CartsController(ICartService cartService)
        {
            _cartService = cartService;
        }

        [HttpGet("{cartId}")]
        public async Task<IActionResult> Details(string cartId) {
            var result = await _cartService.GetByCartId(cartId);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm]CartCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var newCartId = await _cartService.CreateCartItem(request);
            if (string.IsNullOrEmpty(newCartId))
                return BadRequest();
            var cartItem = await _cartService.GetByCartId(newCartId);
            return CreatedAtAction(nameof(Details), new { cartId = newCartId }, cartItem);

          
        }
    }
}
