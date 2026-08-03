using _30_Jult_2026__HW01_.Models;

namespace _30_Jult_2026__HW01_.Service
{
    public interface IEmployeeService
    {
    
        
            List<Employee> GetEmployees();
            Employee GetEmployee(int id);
            Employee AddEmployee(Employee employee);
            Employee UpdateEmployee(Employee employee, int id);
            Employee DeleteEmployee(int id);
            Employee SearchEmployee(int id);
        //Employee GetEmployeeByDepartment(Employee employeed); not this below wala
        List<Employee> GetEmployeesByDepartment(string department);



    }

}

