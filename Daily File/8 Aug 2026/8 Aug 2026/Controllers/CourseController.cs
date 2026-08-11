using _8_Aug_2026.Models;
using _8_Aug_2026.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _8_Aug_2026.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
       
            private readonly ICourseService service;
            public CourseController(ICourseService service)
            {
                this.service = service;
            }
            [HttpGet]
            public IActionResult GetCourses()
            {
                return Ok(service.GetCourses());
            }

            [HttpPost]
            public IActionResult AddCourse(Course course)

            {
                service.AddCourse(course);
                return Ok(course);
            }

            [HttpPut]
            public IActionResult UpdateCourse(int id, Course course)
            {
                var UpdateCourse = service.UpdateCourse(id, course);
                if (UpdateCourse == null)
                {
                    return NotFound();
                }
                return Ok(UpdateCourse);
            }

            [HttpDelete]
            public IActionResult DeleteById(int id)
            {
                var course = service.DeleteCourse(id);
                if (course == null)
                {
                    return NotFound();
                }
                return Ok(course);
            }
        }
    }

