using _13_Aug_2026.Model;
using Microsoft.EntityFrameworkCore;

namespace _13_Aug_2026.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext (DbContextOptions <AppDbContext>options):base(options)
        {

        }

        public DbSet<Customer> Customers => Set<Customer>();
        public DbSet<Product> Products => Set<Product>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Customer>()
                .HasKey(c => c.Id);
            modelBuilder.Entity<Product>()
                .HasKey(p => p.Id);

            // Seed data
            modelBuilder.Entity<Customer>().HasData(
            new Customer
            {
                Id = 1,
                Name = "admin",
                Email = "admin@gmail.com",
                Password = "1234",
                Role = "Admin"
            },
            new Customer
            {
                Id = 2,
                Name = "student",
                Email = "student@gmail.com",
                Password = "1234",
                Role = "Student"
            }
             );
        }
    }
}
