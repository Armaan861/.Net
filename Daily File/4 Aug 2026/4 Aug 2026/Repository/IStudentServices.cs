using _4_Aug_2026.Models;
namespace _4_Aug_2026.Repository
{
    public interface IStudentServices
    {
        List<Student> GetAll();
        Student AddStudent(Student student);
        Student GetStudent(int id);
        Student UpdateStudent(int id, Student student);
        Student DeleteStudent(int id);


    }
}
