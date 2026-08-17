using _12_Aug_2026__Hotel_booking_system_.Models;

namespace _12_Aug_2026__Hotel_booking_system_.Repositary
{
    public interface IBookingService
    {
        List<Booking> GetBookings();
        Booking GetById(int id);
        Booking AddBooking(Booking booking);


    }
}
