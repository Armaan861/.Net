using _12_Aug_2026__Hotel_booking_system_.Models;

namespace _12_Aug_2026__Hotel_booking_system_.Repositary
{
    public interface IHotelService
    {
        List<Hotel> GetHotels();
        Hotel? GetHotelById(int id);
        Hotel AddHotel(Hotel hotel);

    }
}
