using _10_Aug_2026.Data;
using _10_Aug_2026.Models;
using _10_Aug_2026.Repositary;

namespace _10_Aug_2026.Services
{
    public class BookingServices : IBookingServices
    {
        private readonly AppDbContext context;

        public BookingServices(AppDbContext context)
        {
            this.context = context;
        }

        public Booking CreateBooking(Booking booking)
        {
            // 1. Validate Travel Date
            if (booking.TravelDate.Date < DateTime.UtcNow.Date)
                throw new ArgumentException("Travel Date cannot be in the past.");

            // 2. Validate Bus existence
            var bus = context.Buses.FirstOrDefault(b => b.Id == booking.BusId);
            if (bus == null)
                throw new ArgumentException($"Invalid Bus. No bus found with ID {booking.BusId}.");

            // 3. Validate Seat Number against Bus capacity
            if (booking.SeatNumber < 1 || booking.SeatNumber > bus.TotalSeats)
                throw new ArgumentException($"Seat number must be between 1 and {bus.TotalSeats}.");

            // 4. Validate Destination State existence
            var state = context.States.FirstOrDefault(s => s.Id == booking.StateId);
            if (state == null)
                throw new ArgumentException($"Invalid destination state. No state found with ID {booking.StateId}.");

            // 5. Validate Passenger existence
            var passenger = context.Passengers.FirstOrDefault(p => p.Id == booking.PassengerId);
            if (passenger == null)
                throw new ArgumentException($"Invalid Passenger. No passenger found with ID {booking.PassengerId}.");

            // 6. Check if seat is already booked for the exact Bus, Date, and Seat Number
            var alreadyBooked = context.Bookings.Any(b => 
                b.BusId == booking.BusId && 
                b.TravelDate.Date == booking.TravelDate.Date && 
                b.SeatNumber == booking.SeatNumber);

            if (alreadyBooked)
                throw new ArgumentException("This seat is already booked for the selected date.");

            // 7. Save the incoming booking object directly
            context.Bookings.Add(booking);
            context.SaveChanges();

            return booking;
        }

        public Booking GetBookingById(int id)
        {
            return context.Bookings.Find(id);
        }

        public List<Booking> GetBookings()
        {
            return context.Bookings.ToList();
        }
    }
}