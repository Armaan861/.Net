using _10_Aug_2026.Models;
using _10_Aug_2026.Repositary;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _10_Aug_2026.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingServices services;

        public BookingController(IBookingServices services)
        {
            this.services = services;
        }

        [HttpGet]
        public IActionResult GetBook()
        {
            return Ok(services.GetBookings());
            
        }

        [HttpGet("{id}")]
        public IActionResult GetBookingId(int id)
        {
            var booking = services.GetBookingById(id);

            if (booking == null)
                return NotFound("Student is not available");

            return Ok(booking);
        }

        //[HttpPost]
        //public IActionResult CreateBooking(Booking booking)
        //{
        //    services.CreateBooking(booking);
        //    return Ok(booking);

        [HttpPost]
        public IActionResult CreateBooking([FromBody] Booking booking)
        {
            try
            {
                var createdBooking = services.CreateBooking(booking);
                return Ok(createdBooking);
            }
            catch (ArgumentException ex)
            {
                // Returns a clean 400 Bad Request error response in Swagger
                return BadRequest(new { message = ex.Message });
            }
        }

    }
}
