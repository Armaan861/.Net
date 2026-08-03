using _29_july_2026.Controllers.Models;
using System.ComponentModel.DataAnnotations;

namespace _29_july_2026.Controllers.Services
{
    public class EmployeeServise : IEmployeeServise
    {
        private static List<Employee> employees = new List<Employee>()
        {
            new Employee{Id = 101 , Name = "Armaan", phoneN = 1234567890, Email = "armaangupta123@gmail.com", DeptId = 11},
            new Employee{Id = 101 , Name = "Armaan", phoneN = 1234567890, Email = "armaangupta123@gmail.com", DeptId = 11},

            new Employee{Id = 101 , Name = "Armaan", phoneN = 1234567890, Email = "armaangupta123@gmail.com", DeptId = 11},
            new Employee{Id = 101 , Name = "Armaan", phoneN = 1234567890, Email = "armaangupta123@gmail.com", DeptId = 11},

        };

        public List<Employee> getEmployee() 
        {
            return employees;
        }

        public Employee getEmployee(int deptid)
        {
            return employees.FirstOrDefault(e => e.DeptId == deptid);
        }


        public Employee getEmployeeName(string Name)
        {
            return employees.FirstOrDefault(e =>e.Name == e.Name);

        }


        public Employee addEmployee(Employee employee)
        {
            employees.Add(employee);
            return employee;
        }


    }
}
