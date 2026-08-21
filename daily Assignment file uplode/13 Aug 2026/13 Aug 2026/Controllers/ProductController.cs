using _13_Aug_2026.Model;
using _13_Aug_2026.Repositary;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _13_Aug_2026.Controllers
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
        public IActionResult GetAll()
        {
            service.GetProducts();
            return Ok();
        }

        [HttpGet("{id}")]
        [Authorize]
        public IActionResult GetById(int id)
        {
            var product = service.GetById(id);
            if(product == null)
            {
                return NotFound();
            }
            return Ok(product);

        }

        [HttpPost]
        [Authorize(Roles  ="Admin")]
        public IActionResult AddProduct(Product product)
        {
         var addProduct =   service.AddProduct(product);
            return Ok(addProduct);
        }


        [HttpDelete]
        [Authorize(Roles = "Admin")]
        public IActionResult DeleteProduct(int id)
        {
             service.DeleteProduct(id);
            return Ok("Product is Deleted");
        }
    }
}
