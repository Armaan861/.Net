using _8_Aug_2026.Models;
using _8_Aug_2026.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _8_Aug_2026.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
       
            private readonly ITeacherService service;
            public TeacherController(ITeacherService service)
            {
                this.service = service;
            }
            [HttpGet]
            public IActionResult GetTeachers()
            {
                return Ok(service.GetTeachers());
            }


            [HttpPost]
            public IActionResult AddStudent(Teacher teacher)

            {
                service.AddTeacher(teacher);
                return Ok(teacher);
            }

            [HttpPut]
            public IActionResult UpdateStudent(int id, Teacher teacher)
            {
                var UpdateTeacher = service.UpdateTeacher(id, teacher);
                if (UpdateTeacher == null)
                {
                    return NotFound();
                }
                return Ok(UpdateTeacher);
            }

            [HttpDelete]
            public IActionResult DeleteById(int id)
            {
                var teacher = service.DeleteTeacher(id);
                if (teacher == null)
                {
                    return NotFound();
                }
                return Ok(teacher);
            }
        }
}
