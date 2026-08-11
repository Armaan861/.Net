using _10_Aug_2026__HW_.Models;

namespace _10_Aug_2026__HW_.Repositary
{
    public interface IBookingService
    {
        List<Booking> GetBookings();
        Booking GetBookingById(int id);
        Booking CreateBooking(Booking booking);
    }
}
