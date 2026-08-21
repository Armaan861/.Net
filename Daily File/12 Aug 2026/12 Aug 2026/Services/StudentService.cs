using _12_Aug_2026.Data;
using _12_Aug_2026.Models;
using _12_Aug_2026.Reposatary;
using Microsoft.EntityFrameworkCore.Metadata;

namespace _12_Aug_2026.Services
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

            public Student? GetStudentById(int id)
            {
                return context.Students.Find(id);
            }

            public List<Student> GetStudents()
            {
                return context.Students.ToList();
            }

            

            
            }
        }
    

