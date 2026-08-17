namespace _12_Aug_2026__Hotel_booking_system_.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string? Name { get; set; } = string.Empty;
        public string ?City { get; set; } = string.Empty;

        public ICollection<Room> ?Rooms { get; set; } = new List<Room>();
    }
}
