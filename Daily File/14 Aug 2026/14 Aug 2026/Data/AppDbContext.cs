using _14_Aug_2026.Models;
using Microsoft.EntityFrameworkCore;

namespace _14_Aug_2026.Data
{
    public class AppDbContext : DbContext
    {
     public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }




        public DbSet<Customer> Customers =>Set<Customer>();
        public DbSet<Product>Products=> Set<Product>();

        public DbSet<CustomerProduct> CustomerProduct=> Set<CustomerProduct>();

       protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);

    // Composite Primary Key
    modelBuilder.Entity<CustomerProduct>()
        .HasKey(cp => new { cp.CustomerId, cp.ProductId });

    // Customer -> CustomerProduct
    modelBuilder.Entity<CustomerProduct>()
        .HasOne(cp => cp.Customer)
        .WithMany(c => c.CustomerProduct)
        .HasForeignKey(cp => cp.CustomerId)
        .OnDelete(DeleteBehavior.Cascade);

    // Product -> CustomerProduct
    modelBuilder.Entity<CustomerProduct>()
        .HasOne(cp => cp.Product)
        .WithMany(p => p.CustomerProduct)
        .HasForeignKey(cp => cp.ProductId)
        .OnDelete(DeleteBehavior.Cascade);

    // Email must be unique
    modelBuilder.Entity<Customer>()
        .HasIndex(c => c.Email)
        .IsUnique();

            // Seed data
            modelBuilder.Entity<Customer>().HasData(
            new Customer
            {
                Id = 1,
                Name = "admin",
                Email = "admin@gmail.com",
                Passward = "1234",
                Role = "Admin"
            },
            new Customer
            {
                Id = 2,
                Name = "student",
                Email = "student@gmail.com",
                Passward = "1234",
                Role = "Student"
            }
        
    );
}
    }
}
