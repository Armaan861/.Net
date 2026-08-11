using _8_Aug_2026.Data;
using _8_Aug_2026.Models;
using _8_Aug_2026.Repository;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace _8_Aug_2026.Services
{
    public class StudentService : IStudentService
    {
        private readonly AppDbContext context;
        public StudentService(AppDbContext context)
        {
            this.context = context;
        }
        public Student AddStudent(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
            return student;
        }

        public Student DeleteStudent(int id)
        {
            var student = context.Students.Find(id);
            if (student != null)
            {
                context.Students.Remove(student);
                context.SaveChanges();
            }
            return student;
        }

        public Student GetStudentById(int id)
        {
            return context.Students.Find(id);
        }

        public List<Student> GetStudents()
        {
            return context.Students.ToList();
        }

        public Student UpdateStudent(int id, Student student)
        {
            var existing = context.Students.Find(id);
            if(existing != null) 
                context.Entry(existing).CurrentValues.SetValues(student);
            context.SaveChanges();
            return existing;
        }
    }
}