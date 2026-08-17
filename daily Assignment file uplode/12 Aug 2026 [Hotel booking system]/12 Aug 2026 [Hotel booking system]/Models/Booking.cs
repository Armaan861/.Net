namespace _12_Aug_2026__Hotel_booking_system_.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string ?CheckIn { get; set; }
        public string ? CheckOut {  get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; }

        // MANY Bookings belong to ONE Customer
        public Customer Customer { get; set; } = null!;

        // One Booking has MANY BookingRooms

        public ICollection<BookingRoom> BookingRooms { get; set; }
                = new List<BookingRoom>();
    }
}
