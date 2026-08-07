using _4_Aug_2026.Models;
using Microsoft.EntityFrameworkCore;
namespace _4_Aug_2026.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}

