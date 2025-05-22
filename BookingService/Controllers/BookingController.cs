using Microsoft.AspNetCore.Mvc;
using BookingService.Services;
using BookingService.Dtos;


namespace BookingService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        // GET: api/booking
        [HttpGet]
        public IActionResult GetAllBookings()
        {
            var bookings = _bookingService.GetAllBookings();
            return Ok(bookings);
        }


        // POST: api/booking
        [HttpPost]
        public IActionResult AddBooking([FromBody] CreateBookingDto newBooking)
        {
            var createdBooking = _bookingService.AddBooking(newBooking);

            // AI-genererad kod: CreatedAtAction användes för att returnera 201 Created med korrekt länk till resurs
            return CreatedAtAction(nameof(GetBookingById), new { id = createdBooking.Id }, createdBooking);
        }


        // GET: api/booking/{id}
        [HttpGet("{id}")]
        public IActionResult GetBookingById(Guid id)
        {
            var booking = _bookingService.GetBookingById(id);

            if (booking == null)
                return NotFound($"No booking found with ID: {id}");

            return Ok(booking);
        }


        // DELETE: api/booking/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(Guid id)
        {
            var booking = _bookingService.GetBookingById(id);
            if (booking == null)
                return NotFound($"No booking found with ID: {id}");

            _bookingService.DeleteBooking(id);
            return Ok($"Booking with ID {id} has been deleted.");
        }


        // UPPDATE: api/booking/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateBooking(Guid id, [FromBody] UpdateBookingDto updatedBooking)
        {
            var existing = _bookingService.GetBookingById(id);
            if (existing == null)
                return NotFound($"No booking found with ID: {id}");

            _bookingService.UpdateBooking(id, updatedBooking);
            return Ok($"Booking with ID {id} has been updated.");
        }

    }
}
