using _7_Aug_2026.Models;
using _7_Aug_2026.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _7_Aug_2026.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
       
            private readonly IOrderService service;

            public OrdersController(IOrderService service)
            {
                this.service = service;
            }
        // GET: api/Product
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(service.GetOrders());
        }


    }

}
