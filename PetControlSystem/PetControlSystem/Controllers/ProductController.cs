using Microsoft.AspNetCore.Mvc;
using PetControlSystem.Dto;
using PetControlSystem.Services.Interfaces;

namespace PetControlSystem.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public IActionResult Create([FromBody] ProductDto input)
        {
            var result = _productService.Create(input);

            if (result.IsFailed) return BadRequest(result.Errors);

            return CreatedAtAction(nameof(Create), result.Value);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var result = _productService.Delete(id);

            if (result.IsFailed) return NotFound(result.Errors);

            return NoContent();
        }

        [HttpGet("{id}")]
        public IActionResult Read(long id)
        {
            var result = _productService.Read(id);

            if (result.IsFailed) return NotFound(result.Errors);

            return Ok(result.Value);
        }

        [HttpGet]
        public IActionResult ReadAll()
        {
            var result = _productService.ReadAll();

            if (result.IsFailed) return NotFound(result.Errors);

            return Ok(result.Value);
        }
    }
}
