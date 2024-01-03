using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NhaThuocOnline.Application.Interface;
using NhaThuocOnline.ViewModel.Cart;

namespace NhaThuocOnline.WebApi.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly ICartService _cartService;

        public OrdersController(IOrderService orderService, ICartService cartService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public IActionResult Create()
        {
            return Ok();
        }

        [HttpGet("checkout")]
        public async Task<IActionResult> GetProductInCart(string cartId)
        {  
            var result = await _orderService.GetProductByCartId(cartId);
            return Ok(result);
        }

       
    }
}
