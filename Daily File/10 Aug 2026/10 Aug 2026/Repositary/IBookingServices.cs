using _10_Aug_2026.Models;

namespace _10_Aug_2026.Repositary
{
    public interface IBookingServices
    {
        List<Booking> GetBookings();
        Booking GetBookingById(int id);
        Booking CreateBooking(Booking booking);
    }
}
