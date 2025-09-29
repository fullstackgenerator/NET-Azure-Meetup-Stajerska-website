using MeetupWebsite.Sessionize;
using Microsoft.AspNetCore.Components;

namespace MeetupWebsite.Pages
{
    public partial class Home(SessionizeClient sessionizeClient, ILogger<Home> logger, IConfiguration configuration)
    {
        private SessionizeResponse? sessionizeData;
        private SessionizeDaySchedule[]? scheduleData;

        protected override async Task OnInitializedAsync()
        {
            try
            {
                var eventId = configuration["Sessionize:EventId"];

                sessionizeData = await sessionizeClient.GetDataAsync(eventId);
                scheduleData = await sessionizeClient.GetScheduleAsync(eventId);
            }
            catch (Exception ex)
            {
                logger.LogError($"Error fetching Sessionize data: {ex.Message}");
            }
        }

        private MarkupString GetMarkup(string? text)
        {
            // put <br> tags in for new lines, since Sessionize uses plain text with new lines

            text = text?.Replace("\n", "<br />");
            return new MarkupString(text ?? string.Empty);
        }

    }
}