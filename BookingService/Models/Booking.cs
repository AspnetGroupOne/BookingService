namespace BookingService.Models
{
    public class Booking
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public string Event { get; set; } = string.Empty;
        public string TicketCategory { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        // AI-genererad egenskap: Amount beräknas automatiskt som Price * Quantity
        public decimal Amount => Price * Quantity;
        public string Status { get; set; } = "Pending";
        public string? Voucher { get; set; }
        public DateTime Date { get; set; }
    }
}
