using BookingService.Models;

namespace BookingService.Repositories
{
    public interface IBookingRepository
    {
        IEnumerable<Booking> GetAll();
        Booking? GetById(Guid id);
        void Add(Booking booking);
        void Delete(Guid id);
        void Update(Booking booking);

    }
}
