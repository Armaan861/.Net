using _30_Jult_2026__HW01_.Models;
using _30_Jult_2026__HW01_.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _30_Jult_2026__HW01_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        // Dependency Injection connects your controller to your service

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_employeeService.GetEmployees());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var employee = _employeeService.GetEmployee(id);
            if (employee == null)
            {
                return NotFound("Employee is not found ");
            }
            return Ok(employee);
        }


        [HttpPost]
        public IActionResult Add(Employee employee)
        {
            var created = _employeeService.AddEmployee(employee);
            return Ok(created);
        }

        [HttpPut]
        public IActionResult UpdateEmployee(Employee employee,int id)
        {
            var updated = _employeeService.UpdateEmployee(employee, id);
            if (updated == null)
            {
                return NotFound("Employee is not found");
            }
            return Ok(updated);
        }



        [HttpDelete]
        public IActionResult DeleteEmployee(int id)
        {
            var deleted = _employeeService.DeleteEmployee(id);
            if (deleted == null)
            {
                return NotFound("Employee is not found");
            }
            return Ok(deleted);
        }

        
        [HttpGet("search/{id}")] // This creates a unique URL: /api/employee/search/5
        public IActionResult SearchEmployee(int id)
        {
            var employee = _employeeService.SearchEmployee(id);
            if (employee == null)
            {
                return NotFound("Employee is not found");
            }
            return Ok(employee);
        }


        //[HttpGet("department/{id}")]
        //public IActionResult GetEmployeesByDepartment(int id)
        //{
        //    var employees = _employeeService.GetEmployeeByDepartment(id);
        //    return Ok(employees);
        //}

        [HttpGet("department/{department}")]
        public IActionResult GetEmployeesByDepartment(string department)
        {
            var result = _employeeService.GetEmployeesByDepartment(department);

            if (result.Count == 0)
            {
                return NotFound("No employees found in this department.");
            }

            return Ok(result);
        }

    }
}
