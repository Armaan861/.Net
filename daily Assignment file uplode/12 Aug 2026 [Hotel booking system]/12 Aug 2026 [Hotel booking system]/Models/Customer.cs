namespace _12_Aug_2026__Hotel_booking_system_.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }

        // One Customer has MANY Bookings

        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    }
}
