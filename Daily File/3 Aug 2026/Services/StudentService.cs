using _3_Aug_2026.Models;
using _3_Aug_2026.Repository;
namespace _3_Aug_2026.Services
{
    public class StudentService : IStudentService
    {
        private static List<Student> students = new List<Student>() { 
            new Student{Id = 1 , Name = "Armaan Gupta" , Age = 20 , Course = "BE" , Email = "armaangupta23@gmail.com" },
            new Student{Id = 2 , Name = "Rohit Kumar " , Age = 22 , Course = "BSC" , Email = "rohitkumar123@gmail.com"},
            new Student {Id = 3 , Name = "abc Kumar " , Age = 25 , Course = "zac" , Email = "abctkumar456@gmail.com" },
        };

        public List<Student> GetAll()
        {
            return students;
        }

        public Student GetStudent(int id)
        {
            return students.FirstOrDefault(s => s.Id == id);
        }

        public Student AddStudent(Student student)
        {
            students.Add(student);
            return student; // Added return statement
        }

        public Student UpdateStudent(Student student)
        {
            var existing = GetStudent(student.Id);
            if(existing == null)
            
                throw new Exception("Student not Found");
            existing.Age = student.Age;
            return existing; // Added return statement

        }

        public Student DeleteStudent(int id)
        {
            var existing = GetStudent(id);
            if (existing == null)
            {
                throw new Exception("Student not Found");
            }
            students.Remove(existing);
            return existing; // Added return statement
        }

    }
}
