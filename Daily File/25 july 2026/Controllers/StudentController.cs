using Microsoft.AspNetCore.Mvc;
using _25_JULY_2026.Models;

namespace _25_JULY_2026.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private static List<Student> students = new()
        {
            new Student
            {
                Id = 1,
                Name = "John Doe",
                Age = 20,
                Department = "Computer Science"
            },
            new Student
            {
                Id = 2,
                Name = "Jane Smith",
                Age = 22,
                Department = "Mathematics"
            },
            new Student
            {
                Id = 3,
                Name = "Michael Johnson",
                Age = 21,
                Department = "Physics"
            }
        };

        // GET: api/Student
        [HttpGet]
        public ActionResult<IEnumerable<Student>> GetStudents()
        {
            return Ok(students);
        }

        // GET: api/Student/5
        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }
        [HttpPost]//add new student in the existing list 
        public IActionResult AddStudent(Student student)
        {
            students.Add(student);
            return CreatedAtAction(nameof(GetStudent),  //ceated 201
            new { Id = student.Id }, student);
        }

        [HttpPut("{id}")] //edit or modify existing student database on id

        public IActionResult UpdateStudent(int id, Student updateStudent)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student == null)
                return NotFound();

            student.Age = updateStudent.Age;

            return NoContent();
        }


        [HttpDelete("{id}")] // deleate

        public IActionResult DeleateStudent(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student == null)
                return NotFound();//400

            students.Remove(student);

            return NoContent();//204
        }
    }
}