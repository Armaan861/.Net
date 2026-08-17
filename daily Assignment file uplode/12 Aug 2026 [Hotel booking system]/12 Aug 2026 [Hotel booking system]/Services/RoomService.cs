using _12_Aug_2026__Hotel_booking_system_.Data;
using _12_Aug_2026__Hotel_booking_system_.DTO;
using _12_Aug_2026__Hotel_booking_system_.Models;
using _12_Aug_2026__Hotel_booking_system_.Repositary;
using Microsoft.EntityFrameworkCore;

namespace _12_Aug_2026__Hotel_booking_system_.Services
{
    public class RoomService : IRoomService
    {
        private readonly AppDbContext context;

        public RoomService(AppDbContext context)
        {
            this.context = context;
        }

        public Room AddRoom(RoomDto roomDto)
        {
            // DTO → Model
            Room room = new Room
            {
                HotelId = roomDto.HotelId,
                RoomNumber = roomDto.RoomNumber,
                RoomType = roomDto.RoomType,
                Price = roomDto.Price
            };

            context.Rooms.Add(room);
            context.SaveChanges();

            return room;
        }

        public Room? GetById(int id)
        {
            return context.Rooms.Find(id);
        }

        public List<Room> GetRooms()
        {
            return context.Rooms.ToList();
        }
    }
}