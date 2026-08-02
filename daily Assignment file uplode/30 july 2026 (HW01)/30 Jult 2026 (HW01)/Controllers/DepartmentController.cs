using _30_Jult_2026__HW01_.Models;
using _30_Jult_2026__HW01_.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _30_Jult_2026__HW01_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;

        // Dependency Injection connects your controller to your service

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_departmentService.GetDepartments());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var department = _departmentService.GetDepartment(id);
            if (department == null)
            {
                return NotFound("Department not found");
            }
            return Ok(department);
        }

        [HttpPost]
        public IActionResult Add(Department department)
        {
            var created = _departmentService.AddDepartment(department);
            return Ok(created);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDepartment(int id)
        {
            var deleted = _departmentService.DeleteDepartment(id);
            if(deleted == null)
            {
                return NotFound("Department not found");
            }
            return Ok(deleted);
            
        }


        [HttpPut("{id}")]
        public IActionResult UppdateDepartment(int id, Department department)
        {
            var updated = _departmentService.UpdateDepartment(department, id);
            if (updated == null)
            {
                return NotFound("Department not found");
            }
            return Ok(updated);
        }

    }
}
