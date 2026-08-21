using _3_Aug_2026.Models;

namespace _3_Aug_2026.Repository
{
    public interface IStudentService
    {
        List<Student> GetAll();
        Student GetStudent(int id);
        Student AddStudent(Student student);
        Student UpdateStudent(Student student);
        Student DeleteStudent(int id);
    }
}
