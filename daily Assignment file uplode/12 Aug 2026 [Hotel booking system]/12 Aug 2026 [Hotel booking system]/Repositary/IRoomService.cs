using _12_Aug_2026__Hotel_booking_system_.DTO;
using _12_Aug_2026__Hotel_booking_system_.Models;

namespace _12_Aug_2026__Hotel_booking_system_.Repositary
{
    public interface IRoomService
    {
        List<Room> GetRooms();
        Room GetById(int id);
        Room AddRoom(RoomDto room);
    }
}
