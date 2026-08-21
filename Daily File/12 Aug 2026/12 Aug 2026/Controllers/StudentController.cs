using _12_Aug_2026.Models;
using _12_Aug_2026.Reposatary;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace _12_Aug_2026.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService service;

        public StudentController(IStudentService service)
        {
            this.service = service;
        }


        //Get All - Admin + Student
        [HttpGet]
        [Authorize(Roles = "Admin Student")]
        public IActionResult GetAll()
        {
            var student = service.GetStudents();//
            return Ok(service);
        }


        //get Student by id - Admin + Student
        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            var student = service.GetStudentById(id);//
            if (student == null)
                return NotFound("Student not Found");
            return Ok(student);
        }

        //Add new Student - post - Admin
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult AddStudent(Student student)
        {
            var student1 = service.AddStudent(student);
            return Ok(student1);
        }


    }
}