using _14_Aug_2026.Models;
using _14_Aug_2026.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _14_Aug_2026.Controllers
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


        [HttpGet]
        [Authorize]
        public IActionResult GetAll()
        {
            service.GetCustomers();
            return Ok();
        }

        [HttpGet("{id}")]
        [Authorize]

        public IActionResult GetCustomer(int id)
        {
            var cust = service.GetCustomerById(id);
            if (cust == null)
                return NotFound("No Customer");
            return Ok();
        }

        [HttpPost]
        [Authorize]
        public IActionResult AddCustomer(Customer customer)
        {
            service.AddCustomer(customer);
            return Ok();
        }
    }

}
