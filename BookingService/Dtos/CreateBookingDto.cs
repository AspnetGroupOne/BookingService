namespace BookingService.Dtos
{
    public class CreateBookingDto
    {
        public string Name { get; set; } = string.Empty;
        public string Event { get; set; } = string.Empty;
        public string TicketCategory { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; } = "Pending";
        public string? Voucher { get; set; }
        public DateTime Date { get; set; }
    }
}
