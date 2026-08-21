using _13_Aug_2026.Model;
using _13_Aug_2026.Repositary;
using _13_Aug_2026.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _13_Aug_2026.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService service;
        public CustomerController(ICustomerService service)
        {
            this.service = service;
        }

        [HttpPost("register")]
        public IActionResult Register(Customer customer)
        {
            var result = service.Register(customer);

            return Ok(result);
        }
    }
}
