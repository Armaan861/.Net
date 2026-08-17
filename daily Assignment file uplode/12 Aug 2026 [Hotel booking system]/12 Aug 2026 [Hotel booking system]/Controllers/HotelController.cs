using _12_Aug_2026__Hotel_booking_system_.Models;
using _12_Aug_2026__Hotel_booking_system_.Repositary;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _12_Aug_2026__Hotel_booking_system_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IHotelService service;
        public HotelController(IHotelService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult GetALl()
        {
            service.GetHotels();
            return Ok();
        }



        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var hotel = service.GetHotelById(id);
            if (hotel == null)
            {
                return NotFound();
            }
            return Ok();
        }



        [HttpPost]
        public IActionResult AddHotel(Hotel hotel)
        {
            var addproduct = service.AddHotel(hotel);
            return Ok(addproduct);
        }

    }
}
