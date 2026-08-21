using _29_july_2026.Controllers.Models;
    namespace _29_july_2026.Controllers.Services
{
    public interface IEmployeeServise
    {
        List<Employee> getEmployee();
        Employee? getEmployee(int deptid);
        Employee? getEmployeeName(string Name);
        Employee? addEmployee(Employee employee);

    }
}
