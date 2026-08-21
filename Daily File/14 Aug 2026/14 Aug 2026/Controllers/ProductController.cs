using _14_Aug_2026.Models;
using _14_Aug_2026.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _14_Aug_2026.Controllers
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

        [HttpGet]
        [Authorize]
        public IActionResult GetALl()
        {
            service.GetProducts();
            return Ok();
        }


        [HttpGet("{Id}")]
        [Authorize]
        public IActionResult GetById(int id)
        {
            var product = service.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok();
        }


        [HttpPost]
        [Authorize]
        public IActionResult AddProduct(Product product)
        {
            var addproduct = service.AddProduct(product);
            return Ok(addproduct);
        }

        [HttpPut("{id}")]
        [Authorize]
        public IActionResult UpdateProduct(int id, Product product)
        {
            var exesting = service.UpdateProduct(id, product);
            if (exesting == null)
            {
                return NotFound();

            }
            return Ok(exesting);
        }
    }
}