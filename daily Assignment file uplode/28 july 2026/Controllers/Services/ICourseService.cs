using _28_july_2026__HW01_.Controllers.Models;
using System.Net.Http.Headers;




namespace _28_july_2026__HW01_.Controllers.Services
{
    public interface ICourseService
    {

        List<Course> GetAllCourse();

        Course GetById(int id);
        Course AddCourse(Course course);

        Course UpdateCourse(int id, Course course);

        bool DeleteCourse(int id);
    }
    
}
