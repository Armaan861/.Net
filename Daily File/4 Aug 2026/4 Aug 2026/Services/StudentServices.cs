using _4_Aug_2026.Data;
using _4_Aug_2026.Models;
using _4_Aug_2026.Repository;
using System.Collections.Generic;
using System.Linq;

namespace _4_Aug_2026.Services
{
    // FIX 1: Renamed to plural (StudentServices / IStudentServices)
    public class StudentServices : IStudentServices
    {
        private readonly AppDbContext context;

        public StudentServices(AppDbContext context)
        {
            this.context = context;
        }

        public List<Student> GetAll()
        {
            return context.Students.ToList();
        }

        // FIX 2: Fixed return type to match interface
        public Student GetStudent(int id)
        {
            return context.Students.Find(id);
        }

        // FIX 3: Return type changed from void -> Student
        public Student AddStudent(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
            return student;
        }

        // FIX 4: Updated signature to (int id, Student student) and returns Student
        public Student UpdateStudent(int id, Student student)
        {
            var existing = context.Students.Find(id);
            if (existing != null)
            {
                context.Entry(existing).CurrentValues.SetValues(student);
                context.SaveChanges();
            }
            return existing;
        }

        // FIX 5: Return type changed from void -> Student
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
    }
}