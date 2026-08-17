using _12_Aug_2026__Hotel_booking_system_.Models;
using Microsoft.EntityFrameworkCore;

namespace _12_Aug_2026__Hotel_booking_system_.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { }

    public DbSet<Hotel> Hotels => Set<Hotel>();
    public DbSet<Room> Rooms => Set<Room>();
    public DbSet<Customer> Customers => Set<Customer>();
    public DbSet<Booking> Bookings => Set<Booking>();
    public DbSet<BookingRoom> BookingRooms => Set<BookingRoom>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // BookingRoom -> Composite Primary Key
        modelBuilder.Entity<BookingRoom>()
            .HasKey(br => new { br.BookingId, br.RoomId });

        // Hotel -> Room
        // One Hotel has Many Rooms
        modelBuilder.Entity<Room>()
                     .HasOne(r => r.Hotel)
                     .WithMany(h => h.Rooms)
                     .HasForeignKey(r => r.HotelId)
                     .OnDelete(DeleteBehavior.Cascade);
        // Customer -> Booking
        // One Customer has Many Bookings
        modelBuilder.Entity<Booking>()
            .HasOne(b => b.Customer)
            .WithMany(c => c.Bookings)
            .HasForeignKey(b => b.CustomerId)
            .OnDelete(DeleteBehavior.Cascade);


        // Booking -> BookingRoom
        // One Booking has Many BookingRooms
        modelBuilder.Entity<BookingRoom>()
            .HasOne(br => br.Booking)
            .WithMany(b => b.BookingRooms)
            .HasForeignKey(br => br.BookingId)
            .OnDelete(DeleteBehavior.Cascade);


        // Room -> BookingRoom
        // One Room has Many BookingRooms
        modelBuilder.Entity<BookingRoom>()
            .HasOne(br => br.Room)
            .WithMany(r => r.BookingRooms)
            .HasForeignKey(br => br.RoomId)
            .OnDelete(DeleteBehavior.Cascade);

        // Seed data
        modelBuilder.Entity<Customer>().HasData(
        new Customer
        {
            Id = 1,
            Name = "admin",
            Email = "admin@gmail.com",

        },
        new Customer
        {
            Id = 2,
            Name = "student",
            Email = "student@gmail.com",

        }
        );
    }
}
