using  _30_Jult_2026__HW01_.Models;
namespace _30_Jult_2026__HW01_.Service
{
    public class DepartmentService : IDepartmentService
    {
        private static List<Department> departments = new List<Department>()
        {
            new Department{ Id =1 , Name = "HR" ,Code =101 , Status = "Valid"},
            new Department{ Id =2 , Name = "IT" ,Code =102 , Status = "Valid"},
            new Department { Id = 3 , Name ="Finance" , Code = 103 , Status = "Valid"},
            new Department{Id = 4 , Name ="Sales " , Code = 104 , Status = "Valid"},
            new Department {Id = 5 ,Name = "Operations", Code = 105, Status = "Valid"},
        };


        public List<Department> GetDepartments()
        {
            return departments;
        }

        public Department GetDepartment(int deptid)
        {
            return departments.FirstOrDefault(d => d.Id == deptid);
        }

        public Department AddDepartment(Department department)
        {
            departments.Add(department);
            return department;
        }

        public Department UpdateDepartment(Department department, int id)
        {
            var existing = departments.FirstOrDefault(d => d.Id == id);
            if (existing == null)
            {
                return null;
                existing.Status = department.Status;     //omly department status and id is changed
            }
            return existing;

        }



        public Department DeleteDepartment(int id)
        {
            var existing = departments.FirstOrDefault(d => d.Id == id);
            if (existing != null)
            {
                departments.Remove(existing);
                return existing ;
            }
            return null;
        }



    }

}
