using System.Net.Http.Json;

namespace MeetupWebsite.Sessionize
{
    public class SessionizeClient(HttpClient client)
    {
        public async Task<SessionizeResponse?> GetDataAsync(string sessionizeEventId)
        {
            var url = $"https://sessionize.com/api/v2/{sessionizeEventId}/view/All";
            var response = await client.GetFromJsonAsync<SessionizeResponse>(url);
            return response;
        }

        public async Task<SessionizeDaySchedule[]?> GetScheduleAsync(string sessionizeEventId)
        {
            var url = $"https://sessionize.com/api/v2/{sessionizeEventId}/view/GridSmart";
            var response = await client.GetFromJsonAsync<SessionizeDaySchedule[]>(url);
            return response;
        }
    }
}
