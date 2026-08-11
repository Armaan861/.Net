using _10_Aug_2026__HW_.Data;
using _10_Aug_2026__HW_.Models;
using _10_Aug_2026__HW_.Repositary;

namespace _10_Aug_2026__HW_.Services
{

    public class BookingService : IBookingService

    {
        private readonly AppDbContext _context;

        public BookingService(AppDbContext context)
        {
            _context = context;
        }

        public List<Booking> GetBookings()
        {
            return _context.Bookings.ToList();
        }

        public Booking GetBookingById(int id)
        {
            return _context.Bookings.Find(id);
        }

        public Booking CreateBooking(Booking booking)
        {
            // 1. Validate dates
            if (booking.StartDate.Date < DateTime.UtcNow.Date)
                throw new ArgumentException("Start date cannot be in the past.");

            if (booking.EndDate <= booking.StartDate)
                throw new ArgumentException("End date must be after the start date.");

            // 2. Validate Vehicle existence
            var vehicle = _context.Vehicles.FirstOrDefault(v => v.Id == booking.VehicleId);
            if (vehicle == null)
                throw new ArgumentException($"Invalid Vehicle. No vehicle found with ID {booking.VehicleId}.");

            // 3. Validate Customer existence
            var customer = _context.Customers.FirstOrDefault(c => c.Id == booking.CustomerId);
            if (customer == null)
                throw new ArgumentException($"Invalid Customer. No customer found with ID {booking.CustomerId}.");

            // 4. Validate Location existence
            var location = _context.Locations.FirstOrDefault(l => l.Id == booking.LocationId);
            if (location == null)
                throw new ArgumentException($"Invalid Location. No location found with ID {booking.LocationId}.");

            // 5. Prevent overlapping bookings for the same vehicle
            bool isAlreadyBooked = _context.Bookings.Any(b =>
                b.VehicleId == booking.VehicleId &&
                booking.StartDate < b.EndDate &&
                booking.EndDate > b.StartDate);

            if (isAlreadyBooked)
                throw new ArgumentException("This vehicle is already booked for the selected date range.");

            // 6. Calculate total cost automatically (Days * DailyRate)
            int totalDays = (int)(booking.EndDate.Date - booking.StartDate.Date).TotalDays;
            booking.TotalCost = totalDays * vehicle.DailyRate;

            _context.Bookings.Add(booking);
            _context.SaveChanges();

            return booking;
        }
    }
}

