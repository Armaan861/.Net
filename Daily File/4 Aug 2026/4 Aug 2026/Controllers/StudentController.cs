using _4_Aug_2026.Models;
using _4_Aug_2026.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using _4_Aug_2026.Services;

namespace _4_Aug_2026.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    // Removed the nested outer class. Keep just one controller class.
    public class StudentsController : ControllerBase
    {
        // FIX 1: Changed to IStudentServices (plural) to match your interface
        private readonly IStudentServices service;

        public StudentsController(IStudentServices service)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(service.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetId(int id)
        {
            var student = service.GetStudent(id);
            if (student == null) return NotFound("Student not found");
            return Ok(student);
        }

        [HttpPost]
        public IActionResult AddS(Student student)
        {
            service.AddStudent(student);
            return Ok(student);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateS(int id, Student student)
        {
            if (id != student.Id) return BadRequest();

            var existing = service.GetStudent(id);
            if (existing == null) return NotFound();

            // FIX 3: Added the 'id' parameter to match what the interface expects
            service.UpdateStudent(id, student);
            return Ok(student);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var student = service.GetStudent(id);
            if (student == null) return NotFound();

            service.DeleteStudent(id);
            return Ok("Student Deleted Successfully");
        }
    }
}