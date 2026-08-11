using _8_Aug_2026.Models;

namespace _8_Aug_2026.Repository
{
    public interface ITeacherService
    {
        List<Teacher> GetTeachers();
        Teacher AddTeacher(Teacher teacher);
        Teacher UpdateTeacher(int id, Teacher teacher);
        Teacher DeleteTeacher(int id);
    }
}
