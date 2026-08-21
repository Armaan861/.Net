using _10_Aug_2026.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace _10_Aug_2026.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) 
        {
        }

        public DbSet<Passenger> Passengers => Set<Passenger>();
        public DbSet<Bus> Buses => Set<Bus>();
        public DbSet <State> States => Set<State>();
        public DbSet<Booking> Bookings => Set<Booking>();


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>().HasOne(b => b.Passenger).WithMany().HasForeignKey(b => b.PassengerId);
            modelBuilder.Entity<Booking>().HasOne(b => b.Bus).WithMany().HasForeignKey(b => b.BusId);
            modelBuilder.Entity<Booking>().HasOne(b => b.State).WithMany().HasForeignKey(b => b.StateId);



            //prevent the same set from being booked twise
            modelBuilder.Entity<Booking>().HasIndex(b => new { b.BusId, b.TravelDate, b.SeatNumber }).IsUnique();

            // Fare precision
            modelBuilder.Entity<Booking>()
                .Property(b => b.Fare)
                .HasPrecision(10, 2);

        }

    }
}
