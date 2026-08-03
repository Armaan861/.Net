using _30_Jult_2026__HW01_.Models;

namespace _30_Jult_2026__HW01_.Service
{
    public interface IDepartmentService
    {
        List<Department> GetDepartments();
        Department GetDepartment(int deptid);
        Department AddDepartment(Department department);
        Department UpdateDepartment(Department department, int id);
        Department DeleteDepartment(int id);
    }
}
