using _6_Aug_2026.Models;
using Microsoft.EntityFrameworkCore;

namespace _6_Aug_2026.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Order>orders { get; set; }
    }
}
