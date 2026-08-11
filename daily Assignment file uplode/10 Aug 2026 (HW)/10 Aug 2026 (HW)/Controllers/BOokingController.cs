using _10_Aug_2026__HW_.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using _10_Aug_2026__HW_.Repositary;

namespace _10_Aug_2026__HW_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BOokingController : ControllerBase
    {
        private readonly IBookingService _services;

        public BOokingController(IBookingService services)
        {
            _services = services;
        }

        [HttpGet]
        public IActionResult GetBookings()
        {
            return Ok(_services.GetBookings());
        }

        [HttpGet("{id}")]
        public IActionResult GetBookingById(int id)
        {
            var booking = _services.GetBookingById(id);

            if (booking == null)
                return NotFound("Booking not found.");

            return Ok(booking);
        }

        [HttpPost]
        public IActionResult CreateBooking([FromBody] Booking booking)
        {
            try
            {
                var result = _services.CreateBooking(booking);
                return Ok(result);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}
