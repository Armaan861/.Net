using _30_Jult_2026__HW01_.Models;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using _30_Jult_2026__HW01_.Service;

namespace _30_Jult_2026__HW01_.Service
{
    public class EmployeeService : IEmployeeService
    {
        private List<Employee> employees = new List<Employee>()
        {
            new Employee{ Id = 1, FirstName = "Armaan", LastName = "Gupta", Email = "Armaan.gupta@example.com" , PhoneN = 1234567890, Dob = "1990-01-01", Gender = "Male", Salary = 500000 , DateOfJoining = "2026-04-26", Department = "IT", Designation = "Software Engineer", EmploymentStatus = "Active"},
            new Employee { Id = 2, FirstName = "Aarav", LastName = "Sharma", Email = "Aarav.sharma@example.com", PhoneN = 0987654321, Dob = "1992-05-15", Gender = "Male", Salary = 600000, DateOfJoining = "2026-04-26", Department = "HR", Designation = "HR Manager", EmploymentStatus = "Active" },
            new Employee { Id = 3, FirstName = "Ananya", LastName = "Verma", Email = "Ananya.verma@example.com", PhoneN = 0987654321, Dob = "1992-05-15", Gender = "Female", Salary = 600000, DateOfJoining = "2026-04-26", Department = "Finance", Designation = "Financial Analyst", EmploymentStatus = "Active" },
            new Employee { Id = 4, FirstName = "Rohan", LastName = "Mehta", Email = "Rohan.mehta@example.com", PhoneN = 0987654321, Dob = "1992-05-15", Gender = "Male", Salary = 600000, DateOfJoining = "2026-04-26", Department = "Marketing", Designation = "Marketing Specialist", EmploymentStatus = "Active" },
            new Employee { Id = 5, FirstName = "Ishita", LastName = "Kapoor", Email = "Ishita.kapoor@example.com", PhoneN = 0987654321, Dob = "1992-05-15", Gender = "Female", Salary = 600000, DateOfJoining = "2026-04-26", Department = "Sales", Designation = "Sales Executive", EmploymentStatus = "Active" }
        };


        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public Employee GetEmployee(int id)
        {
            return employees.FirstOrDefault(e => e.Id == id);
        }

        public Employee AddEmployee(Employee employee)
        {
            employees.Add(employee);
            return employee;
        }

        public Employee UpdateEmployee(Employee employee, int id)
        {
            var existing = employees.FirstOrDefault(e => e.Id == id);
            if (existing == null)
            {
                return null;
            }
            else
            {
                existing.Email = employee.Email;
                existing.PhoneN = employee.PhoneN;
                existing.Dob = employee.Dob;
                existing.Salary = employee.Salary;
                existing.EmploymentStatus = employee.EmploymentStatus;
                return existing;
            }
        }


            public Employee DeleteEmployee(int id)
        {
            var existing = employees.FirstOrDefault(e => e.Id == id);
            if (existing == null)
            {
                return null;

            }
            else
            {
                employees.Remove(existing);
                return existing;
            }
        }


            public Employee SearchEmployee(int id)
        {
            return employees.FirstOrDefault(e => e.Id == id);

        }

        //public Employee GetEmployeeByDepartment(Department department)
      //  {
          //  return employees.FirstOrDefault(e => e.Department == department);
        //}

        public List<Employee> GetEmployeesByDepartment(string department)
        {
            return employees.Where(e => e.Department == department).ToList();
        }

    }
}
    
    
          





