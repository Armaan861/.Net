using _10_Aug_2026__HW_.Models;
using Microsoft.EntityFrameworkCore;

namespace _10_Aug_2026__HW_.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Vehicle> Vehicles => Set<Vehicle>();
        public DbSet<Customer> Customers => Set<Customer>();
        public DbSet<Location> Locations => Set<Location>();
        public DbSet<Booking> Bookings => Set<Booking>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Decimal precision for currency
            modelBuilder.Entity<Vehicle>().Property(v => v.DailyRate).HasPrecision(10, 2);
            modelBuilder.Entity<Booking>().Property(b => b.TotalCost).HasPrecision(10, 2);

            // Relationships
            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Vehicle)
                .WithMany()
                .HasForeignKey(b => b.VehicleId);

            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Customer)
                .WithMany()
                .HasForeignKey(b => b.CustomerId);

            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Location)
                .WithMany()
                .HasForeignKey(b => b.LocationId);
        }
    }
}
