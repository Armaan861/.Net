using _27_july_26.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _27_july_26.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        static List<Employee> employees = new List<Employee>()
        {
            new Employee(){Id= 101,Name="Armaan", LastName= "Gupta",Dept="CSE",PhoneNum= 9876543210, Profile = "Software enginer" , Location = "Nagpur"},
            new Employee(){Id= 103,Name="Vohan", LastName= "hharma",Dept="It",PhoneNum= 8876543211, Profile = " enginer" , Location = "pur"},
        };

        //get all employees list

        [HttpGet]
        public IActionResult Employees()
        {
            return Ok(employees);//ok 200
        }


        //get employee by id
        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
            {
                return NotFound(); // 404 Not Found
            }
            return Ok(employee); // 200 OK
        }



        //add new employee record
        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
           
            employees.Add(employee);
            return Ok(employee); // 201 Created
        }



        //edit eemployee record
        [HttpPut("{id}")]
        public IActionResult UpdateEmployee(int id, Employee employee)
        {
            var employee1 = employees.FirstOrDefault(x => x.Id == id);
            if (employee1 == null)
            {
                return NotFound();
            }
     
                employee.LastName = employee.LastName;
                employee.PhoneNum = employee.PhoneNum;
            return Ok(employee1);

        }


        [HttpGet("Dept/{dept}")]
        public IActionResult GetEmployeeByDept(string dept)
        { 
            var result = employees.Where(s => s.Dept.Equals(dept, StringComparison.OrdinalIgnoreCase)).ToList();
            
           if (!result.Any()) 
            {
                return NotFound("Not employee found under this dept"); 
            } 
            return Ok(result);
        }


        [HttpGet("{Location}")]
        public IActionResult GetEmployeeByLocation(String location)
        {
            var result = employees.Where(e => e.Location.Equals(location, StringComparison.OrdinalIgnoreCase) ).ToList();

            if (!result.Any())
            {
                return NotFound("No employee found in this location.");
            }

            return Ok(result);
        }


        [HttpGet("Profile/{profile}")]
        public IActionResult GetEmployeeByProfile(string profile)
        {
            var result = employees.Where(e => e.Profile.Equals(profile, StringComparison.OrdinalIgnoreCase)).ToList();

            if (!result.Any())
            {
                return NotFound("No employee found with this profile.");
            }

            return Ok(result);
        }



    }
}
