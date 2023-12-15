using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NhaThuocOnline.Application.Interface;
using NhaThuocOnline.ViewModel.Product;

namespace NhaThuocOnline.WebApi.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetProductsPaging()
        {
            var products = await _productService.GetProductsPaging();
            return Ok(products);
        }


        [HttpGet("{productId}")]
        public async Task<IActionResult> GetProductById(int productId)
        {
            var product = await _productService.GetProductById(productId);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Create([FromForm]ProductCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var newProductId = await _productService.Create(request);
            if (newProductId == 0)
               return BadRequest();
            var product= await _productService.GetProductById(newProductId);
            return CreatedAtAction(nameof(GetProductById), new { productId= newProductId}, product);
        }
    }
}
