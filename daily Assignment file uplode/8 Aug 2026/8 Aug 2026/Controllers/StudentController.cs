using _8_Aug_2026.Models;
using _8_Aug_2026.Repository;
using _8_Aug_2026.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _8_Aug_2026.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService service;
        public StudentController(IStudentService service)
        {
            this.service= service;
        }
        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(service.GetStudents());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var student = service.GetStudentById(id);

            if (student == null)
                return NotFound("Student is not available");

            return Ok(student); ;
        }

        [HttpPost]
        public IActionResult AddStudent(Student student)
        
        {
             service.AddStudent(student);
            return Ok(student);
        }

        [HttpPut]
        public IActionResult UpdateStudent( int id ,Student student) 
        {
            var updatedStudent = service.UpdateStudent(id,student);
            if (updatedStudent == null)
            {
                return NotFound();
            }
            return Ok(updatedStudent);
        }

        [HttpDelete]
        public IActionResult DeleteById(int id)
        {
            var student = service.DeleteStudent(id);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }
    }
}
