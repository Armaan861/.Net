namespace _12_Aug_2026__Hotel_booking_system_.Models
{
    public class BookingRoom
    {
        public int BookingId { get; set; }
        public int RoomId { get; set; }
        public decimal Price { get; set; }
        // BookingRoom belongs to ONE Booking
        public Booking Booking { get; set; } = null!;

        // BookingRoom belongs to ONE Room
        public Room Room { get; set; } = null!;

    }
}
