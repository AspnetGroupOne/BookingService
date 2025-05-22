using BookingService.Models;
using BookingService.Dtos;

namespace BookingService.Services
{
    public interface IBookingService
    {
        IEnumerable<Booking> GetAllBookings();
        BookingDto AddBooking(CreateBookingDto newBooking);
        Booking? GetBookingById(Guid id);
        void DeleteBooking(Guid id);
        void UpdateBooking(Guid id, UpdateBookingDto updatedBooking);



    }
}
