using _29_july_2026.Controllers.Models;
using _29_july_2026.Controllers.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _29_july_2026.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeServise _service;  //read only service variable

        public EmployeeController(IEmployeeServise service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.getEmployee());
        }


        [HttpGet("{deptid}")]
        public IActionResult GetById(int deptid)
        {
            var employee = _service.getEmployee(deptid);
            if(employee == null)
            {
                return NotFound("Employee with id not Found");

            }
            return Ok(employee);


        }


        [HttpGet("{name}")]
        public IActionResult GetEmployeeByName(String Name)
        {
            var employee = _service.getEmployeeName(Name);
            if (employee == null)
            {
                return NotFound("Employee with id not Found");
            }
            return Ok(employee);

        }

        [HttpPost]
        public IActionResult Create(Employee employee )
        {
            var created = _service.addEmployee(employee); 
            return Ok(created);
        }


    }
}
