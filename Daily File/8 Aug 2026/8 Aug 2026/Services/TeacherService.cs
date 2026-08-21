using _8_Aug_2026.Data;
using _8_Aug_2026.Models;
using _8_Aug_2026.Repository;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace _8_Aug_2026.Services { 

    public class TeacherService : ITeacherService
    {
    private readonly AppDbContext context;
    public TeacherService(AppDbContext context)
    {
        this.context = context;
    }
    public Teacher AddTeacher(Teacher teacher)
        {
        context.Teachers.Add(teacher);
        context.SaveChanges();
        return teacher;
        }

        public Teacher DeleteTeacher(int id)
        {
            var teacher = context.Teachers.Find(id);
            if (teacher != null)
            {
                context.Teachers.Remove(teacher);
                context.SaveChanges();
            }
                return teacher;
            
        }
        public List<Teacher> GetTeachers()
        {
         return context.Teachers.ToList();   
        }

        public Teacher UpdateTeacher(int id, Teacher teacher)
        {
            var exesting = context.Teachers.Find(id);
            if (exesting != null) 
            {
                context.Entry(exesting).CurrentValues.SetValues(teacher);
                context.SaveChanges();

            }
            return teacher;

        }
    }
}
