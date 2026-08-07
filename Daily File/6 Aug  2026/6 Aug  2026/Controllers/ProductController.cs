using _6_Aug__2026.Models;
using _6_Aug__2026.Repository;
using Microsoft.AspNetCore.Mvc;

namespace _6_Aug__2026.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService service;

        public ProductController(IProductService service)
        {
            this.service = service;
        }

        // GET: api/Product
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(service.GetProducts());
        }

        // GET: api/Product/1
        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var product = service.GetProductById(id);

            if (product == null)
                return NotFound("Product is not available");

            return Ok(product);
        }

        // POST: api/Product
        [HttpPost]
        public IActionResult Add(Product product)
        {
            service.AddProduct(product);
            return Ok(product);
        }

        // PUT: api/Product
        [HttpPut]
        [HttpPut]
        public IActionResult UpdateProduct(Product product)
        {
            service.UpdateProduct(product);
            return Ok(product);
        }

        // DELETE: api/Product/1
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            service.DeleteProduct(id);
            return Ok("Product deleted successfully.");
        }
    }
}