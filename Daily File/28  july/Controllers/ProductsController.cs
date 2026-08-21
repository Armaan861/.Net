using _28_july_2026.Controllers.Models;
using _28_july_2026.Controllers.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _28_july_2026.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductServices _services;

        
        public ProductsController(ProductServices services)
        {
            _services = services;
        }

        [HttpGet]
        public IActionResult GetAll() {
            return Ok(_services.GetAll());
        }


        [HttpGet("{id}")]
        public IActionResult GetProductById(int id) 
        { var product = _services.GetById(id);
            if (product == null)
            { 
                return NotFound(); 
            } 
            return Ok(product); 

        }



        [HttpPost]
        public IActionResult Create(Product product) 
        { 
            var created = _services.AddProduct(product); return Ok(created); 
        }




        [HttpPut("{id}")]
        public IActionResult Update(int id, Product product)
        {
            var updated = _services.UpdateProduct(id, product); 
            if (updated == null) return NotFound(); return Ok(updated);
        }




        [HttpDelete("{id}")]
        public IActionResult delete(int id)
        {
            bool deleted = _services.DeleteProduct(id);
            if (!deleted) return NotFound();
            return NoContent();
        }


    }
}
