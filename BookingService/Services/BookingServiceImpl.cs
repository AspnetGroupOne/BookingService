using BookingService.Dtos;
using BookingService.Models;
using BookingService.Repositories;

namespace BookingService.Services
{
    public class BookingServiceImpl : IBookingService
    {
        private readonly IBookingRepository _repository;

        public BookingServiceImpl(IBookingRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Booking> GetAllBookings()
        {
            return _repository.GetAll();
        }

        public BookingDto AddBooking(CreateBookingDto newBooking)
        {

            // AI-genererad mappning: DTO till Booking-modell (inkl. manuell Id-sättning)
            var booking = new Booking
            {
                Id = Guid.NewGuid(),
                Name = newBooking.Name,
                Event = newBooking.Event,
                TicketCategory = newBooking.TicketCategory,
                Price = newBooking.Price,
                Quantity = newBooking.Quantity,
                Status = newBooking.Status,
                Voucher = newBooking.Voucher,
                Date = newBooking.Date
            };

            _repository.Add(booking);
            // AI-genererad: Manuell mappning från Booking till BookingDto, inkl. beräkning av Amount
            return new BookingDto
            {
                Id = booking.Id,
                Name = booking.Name,
                Event = booking.Event,
                TicketCategory = booking.TicketCategory,
                Price = booking.Price,
                Quantity = booking.Quantity,
                Amount = booking.Price * booking.Quantity,
                Status = booking.Status,
                Voucher = booking.Voucher,
                Date = booking.Date
            };
        }

        public Booking? GetBookingById(Guid id)
        {
            return _repository.GetById(id);
        }

        public void DeleteBooking(Guid id)
        {
            _repository.Delete(id);
        }

        public void UpdateBooking(Guid id, UpdateBookingDto updatedBooking)
        {
            var existingBooking = _repository.GetById(id);
            if (existingBooking == null)
                return;

            existingBooking.Name = updatedBooking.Name;
            existingBooking.Event = updatedBooking.Event;
            existingBooking.TicketCategory = updatedBooking.TicketCategory;
            existingBooking.Price = updatedBooking.Price;
            existingBooking.Quantity = updatedBooking.Quantity;
            existingBooking.Status = updatedBooking.Status;
            existingBooking.Voucher = updatedBooking.Voucher;
            existingBooking.Date = updatedBooking.Date;

            _repository.Update(existingBooking);
        }
    }
}
