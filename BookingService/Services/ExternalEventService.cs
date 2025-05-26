using BookingService.Dtos;

namespace BookingService.Services
{
    public class ExternalEventService
    {
        private readonly HttpClient _httpClient;

        public ExternalEventService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<ExternalEventDto>> GetExternalEventsAsync()
        {
            var response = await _httpClient.GetAsync("https://eventbookingsystem20250526120605-azd2dcckf0guhzde.swedencentral-01.azurewebsites.net/api/events");

            if (!response.IsSuccessStatusCode)
                throw new Exception("Failed to fetch external events");

            var events = await response.Content.ReadFromJsonAsync<IEnumerable<ExternalEventDto>>();
            return events ?? new List<ExternalEventDto>();
        }
    }
}
