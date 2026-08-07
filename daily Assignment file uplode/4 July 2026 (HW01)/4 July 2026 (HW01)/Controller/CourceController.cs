using _4_July_2026__HW01_.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using _4_July_2026__HW01_.Model;
using _4_July_2026__HW01_.Service;

namespace _4_July_2026__HW01_.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourceController : ControllerBase
    {
        private readonly ICourceService _courceService;
        public CourceController(ICourceService courceService)
        {
            _courceService = courceService;
        }

        [HttpGet]
        public IActionResult GetAllCources()
        {
            return Ok(_courceService.GetAllCources());
        }

        [HttpPost]
        public IActionResult AddCource(Cource cource)
        {
            var addedCource = _courceService.AddCource(cource);
            return Ok(addedCource);
        }

        [HttpGet("{id}")]
        public IActionResult GetCource(int id)
        {
            var cource = _courceService.GetCource(id);
            if (cource == null)
            {
                return NotFound();
            }
            return Ok(cource);
        }


        [HttpPut("{id}")]
        public IActionResult UpdateCource(int id, Cource cource)
        {
            var updatedCource = _courceService.UpdateCource(id, cource);
            if (updatedCource == null)
            {
                return NotFound();
            }
            return Ok(updatedCource);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCource(int id)
        {
            var cource = _courceService.DeleteCource(id);
            if (cource == null)
            {
                return NotFound();
            }
            return Ok(cource);
        }

    }
}
