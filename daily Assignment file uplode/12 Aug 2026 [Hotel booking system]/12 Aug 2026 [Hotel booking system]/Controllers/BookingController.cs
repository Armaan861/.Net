using _12_Aug_2026__Hotel_booking_system_.Models;
using _12_Aug_2026__Hotel_booking_system_.Repositary;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _12_Aug_2026__Hotel_booking_system_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService service;
        public BookingController(IBookingService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult GetALl()
        {
            var bookings = service.GetBookings();
            return Ok(bookings);
        }



        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var booking = service.GetById(id);
            if (booking == null)
            {
                return NotFound();
            }
            return Ok(booking);
        }



        [HttpPost]
        public IActionResult AddBooking(Booking booking)
        {
            var addproduct = service.AddBooking(booking);
            return Ok(addproduct);
        }
    }
}
