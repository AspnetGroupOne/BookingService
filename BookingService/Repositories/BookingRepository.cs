using BookingService.Models;
using Microsoft.EntityFrameworkCore;

namespace BookingService.Repositories
{
    public class BookingRepository : IBookingRepository
    {
        private readonly BookingDbContext _context;

        public BookingRepository(BookingDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Booking> GetAll()
        {
            return _context.Bookings.ToList();
        }
        // AI-genererad: Använder FirstOrDefault för att hämta bokning via ID, vilket är ett typiskt EF Core-mönster föreslaget av AI
        public Booking? GetById(Guid id)
        {
            return _context.Bookings.FirstOrDefault(b => b.Id == id);
        }

        public void Add(Booking booking)
        {
            _context.Bookings.Add(booking);
            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var booking = GetById(id);
            if (booking != null)
            {
                _context.Bookings.Remove(booking);
                _context.SaveChanges();
            }
        }

        public void Update(Booking booking)
        {
            _context.Bookings.Update(booking);
            _context.SaveChanges();
        }

    }
}
