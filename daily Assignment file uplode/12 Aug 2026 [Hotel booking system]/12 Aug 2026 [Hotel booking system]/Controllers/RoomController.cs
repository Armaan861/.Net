using _12_Aug_2026__Hotel_booking_system_.DTO;
using _12_Aug_2026__Hotel_booking_system_.Models;
using _12_Aug_2026__Hotel_booking_system_.Repositary;
using Microsoft.AspNetCore.Mvc;

namespace _12_Aug_2026__Hotel_booking_system_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService service;

        public RoomController(IRoomService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var rooms = service.GetRooms();
            return Ok(rooms);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var room = service.GetById(id);

            if (room == null)
            {
                return NotFound();
            }

            return Ok(room);
        }

        [HttpPost]
        public IActionResult AddRoom(RoomDto room)
        {
            var addRoom = service.AddRoom(room);
            return Ok(addRoom);
        }
    }
}