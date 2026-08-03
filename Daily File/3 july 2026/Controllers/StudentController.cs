using _3_Aug_2026.Models;
using _3_Aug_2026.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _3_Aug_2026.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController (IStudentService service)
        {
            _studentService = service;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_studentService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            var student = _studentService.GetStudent(id);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }

        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            if (!ModelState.IsValid)
            
                return BadRequest(ModelState);
           _studentService.AddStudent(student);
            return Ok(AddStudent(student));
           
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, Student student)
        {
            if(id > 0) {
                _studentService.UpdateStudent(student);
                return Ok(student);
            }
            return BadRequest("Invalid student ID.");
        }
        [HttpDelete("{id}")] // <-- Correctly closed with '}'
        public IActionResult DeleteStudent(int id)
        {
            if (id > 0)
            {
                var deletedStudent = _studentService.DeleteStudent(id);
                return Ok(deletedStudent);
            }

            return BadRequest("Invalid student ID.");
        }
    }
}
