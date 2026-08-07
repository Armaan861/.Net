using _4_July_2026__HW01_.Model;
using Microsoft.EntityFrameworkCore;

namespace _4_July_2026__HW01_.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Cource> Cources { get; set; }

    }
}
