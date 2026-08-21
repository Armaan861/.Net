namespace _12_Aug_2026__Hotel_booking_system_.Models
{
    public class Room
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        public string? RoomNumber
            { get; set; }
        public string? RoomType { get; set; } = string.Empty;
        public decimal Price { get; set; }
        // MANY Rooms belong to ONE Hotel
        public Hotel Hotel { get; set; } = null!; public ICollection<BookingRoom> BookingRooms { get; set; } = new List<BookingRoom>();


        // One Room can appear in MANY BookingRoom records
        public ICollection<BookingRoom> BookingRoom { get; set; }
            = new List<BookingRoom>();

    }
}
