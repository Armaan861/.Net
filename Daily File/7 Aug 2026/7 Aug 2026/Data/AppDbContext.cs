using _7_Aug_2026.Models;
using Microsoft.EntityFrameworkCore;

namespace _7_Aug_2026.Data
{
    public class AppDbContext :DbContext
    {

        //constructor recive db configuration throughh DI
        public AppDbContext(DbContextOptions options) : base(options) 
        {
        }

        //represent the product table i db
        public DbSet<Product> Products => Set<Product>();


            //represent the product table i db
        public DbSet<Orders> Orders => Set<Orders>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //one product  -> many orderitems
            modelBuilder.Entity<OrderItems>().HasOne(o => o.product).WithMany(p => p.OrderItems).HasForeignKey(o => o.ProductId);

            //one product  -> many orderitems
            modelBuilder.Entity<OrderItems>().HasOne(o => o.order).WithMany(p => p.OrderItems).HasForeignKey(o => o.OrderId);
        }



    }
}
