using _12_Aug_2026.Models;

namespace _12_Aug_2026.Reposatary
{
    public interface IStudentService
    {
        List<Student> GetStudents();
        Student GetStudentById(int id);
        Student AddStudent(Student student);

    }
}
