using _29_july_2026.Controllers.Models;
using _29_july_2026.Controllers.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _29_july_2026.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleService _service;  // read-only service variable

        public VehicleController(IVehicleService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.getVehicle());
        }

        // Added "by-id" and route constraint to prevent Swagger crash
        [HttpGet("by-id/{id:int}")]
        public IActionResult GetById(int id)
        {
            var vehicle = _service.getVehicle(id);
            if (vehicle == null)
            {
                return NotFound("Vehicle with id not found");
            }
            return Ok(vehicle);
        }

        // Added "by-name" to prevent Swagger crash
        [HttpGet("by-name/{name}")]
        public IActionResult GetVehicleByName(string name)
        {
            var vehicle = _service.getVehicleName(name);
            if (vehicle == null)
            {
                return NotFound("Vehicle with name not found");
            }
            return Ok(vehicle);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Vehicle vehicle)
        {
            var created = _service.addVehicle(vehicle);
            return Ok(created);
        }
    }
}