namespace BookingService.Dtos
{
    public class ExternalEventDto
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public string Location { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int TicketsAvailable { get; set; }
    }
}
