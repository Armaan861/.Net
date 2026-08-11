using _8_Aug_2026.Models;
using Microsoft.EntityFrameworkCore;

namespace _8_Aug_2026.Data
{
    public class AppDbContext : DbContext
    {
        //constructor recive db configuration throughh DI
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        //represent the student table i db
        public DbSet<Student> Students => Set<Student>();


        //represent the teacher table i db
        public DbSet<Teacher> Teachers => Set<Teacher>();

        //represent the course table i db
        public DbSet<Course> Courses => Set<Course>();

        //represent the Batch table i db
        public DbSet<Batch> Batches => Set<Batch>();

        
    
    }
}
