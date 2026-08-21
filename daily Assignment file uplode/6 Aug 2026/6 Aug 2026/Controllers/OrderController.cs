using _6_Aug_2026.Models;
using _6_Aug_2026.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _6_Aug_2026.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService service;
        public OrderController(IOrderService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(service.GetAllOrders());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(service.GetById(id));
        }

        [HttpPost]
        public IActionResult AddOrder(Order order)
        {
            service.AddOrder(order);
            return Ok(order);
        }

        [HttpPut]
        public IActionResult UpdateOrder(Order order)
        { 
            service.UpdateOrder(order);
            return Ok(order.Id);
        }

        [HttpDelete]
        public IActionResult DeleteOrder(int id)
        {
            service.DeleteOrder(id);
            return Ok("Product is deleted");
        }
    }
}
