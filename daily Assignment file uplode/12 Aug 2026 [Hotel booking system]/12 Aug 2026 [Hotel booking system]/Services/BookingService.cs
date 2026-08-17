using _12_Aug_2026__Hotel_booking_system_.Data;
using _12_Aug_2026__Hotel_booking_system_.Models;
using _12_Aug_2026__Hotel_booking_system_.Repositary;

namespace _12_Aug_2026__Hotel_booking_system_.Services
{
    public class BookingService : IBookingService
    {
        private readonly AppDbContext context;
        public BookingService(AppDbContext context)
        {
            this.context = context;
        }

        public Booking AddBooking(Booking booking)
        {

            context.Bookings.Add(booking);
            context.SaveChanges();
            return booking;
        }

        public List<Booking> GetBookings()
        {
            return context.Bookings.ToList();
        }

        public Booking GetById(int id)
        {
            return context.Bookings.Find(id);
        }
    }
}
