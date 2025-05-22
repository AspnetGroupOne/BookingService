namespace BookingService.Dtos
{
    public class BookingDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Event { get; set; } = string.Empty;
        public string TicketCategory { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        // AI-genererad: Amount är beräknat fält (pris × antal) som lades till för att förenkla frontend-användning
        public decimal Amount { get; set; }
        public string Status { get; set; } = "Pending";
        public string? Voucher { get; set; }
        public DateTime Date { get; set; }
    }
}
