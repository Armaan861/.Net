using _7_Aug_2026.Models;
using _7_Aug_2026.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _7_Aug_2026.Controllers
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


       
    }
}
