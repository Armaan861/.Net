using _28_july_2026__HW01_.Controllers.Models;
using _28_july_2026__HW01_.Controllers.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _28_july_2026__HW01_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        // Dependency Injection connects your controller to your service
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        // GET: api/courses
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_courseService.GetAllCourse());
        }

        // GET: api/courses/1
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var course = _courseService.GetById(id);
            if (course == null) return NotFound("Course not found.");
            return Ok(course);
        }

        // POST: api/courses
        [HttpPost]
        public IActionResult Add([FromBody] Course course)
        {
            var created = _courseService.AddCourse(course);
            return Ok(created);
        }

        // PUT: api/courses/1
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Course course)
        {
            var updated = _courseService.UpdateCourse(id, course);
            if (updated == null) return NotFound("Course not found to update.");
            return Ok(updated);
        }

        // DELETE: api/courses/1
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var deleted = _courseService.DeleteCourse(id);
            if (!deleted) return NotFound("Course not found to delete.");
            return Ok("Course deleted successfully.");
        }


        }
}
