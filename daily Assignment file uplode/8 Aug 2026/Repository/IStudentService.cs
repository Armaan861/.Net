using _8_Aug_2026.Models;

namespace _8_Aug_2026.Repository
{
    public interface IStudentService
    {
        List<Student> GetStudents();
        Student GetStudentById(int id);
        Student AddStudent(Student student);
        Student UpdateStudent(int id ,Student student);
        Student DeleteStudent(int id);
    }
}
