using Level_5_API.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Level_5_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("add")]
        public IActionResult Add()
        {
            var result = _productService.Add();
            return Ok(result);
        }
        
        [HttpGet("delete")]
        public IActionResult Delete()
        {
            var result = _productService.Delete();
            return Ok(result);
        }
    }
}
