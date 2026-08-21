using _8_Aug_2026.Models;

namespace _8_Aug_2026.Repository
{
    public interface ICourseService
    {
        List<Course> GetCourses();
        Course AddCourse(Course course);
        Course UpdateCourse(int id ,Course course);
        Course DeleteCourse(int id);
    }
}
