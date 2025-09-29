using System.Text.Json.Serialization;

namespace MeetupWebsite.Sessionize;

public class SessionizeResponse
{

    [JsonPropertyName("sessions")]
    public List<Session> Sessions { get; set; }

    [JsonPropertyName("speakers")]
    public List<Speaker> Speakers { get; set; }

    [JsonPropertyName("rooms")]
    public List<Room> Rooms { get; set; }
}

public class Session
{

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("startsAt")]
    public DateTime StartsAt { get; set; }

    [JsonPropertyName("endsAt")]
    public DateTime EndsAt { get; set; }

    [JsonPropertyName("isServiceSession")]
    public bool IsServiceSession { get; set; }

    [JsonPropertyName("isPlenumSession")]
    public bool IsPlenumSession { get; set; }

    [JsonPropertyName("speakers")]
    public List<string> Speakers { get; set; }

    [JsonPropertyName("roomId")]
    public int RoomId { get; set; }

    [JsonPropertyName("liveUrl")]
    public string LiveUrl { get; set; }

    [JsonPropertyName("recordingUrl")]
    public string RecordingUrl { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("isInformed")]
    public bool IsInformed { get; set; }

    [JsonPropertyName("isConfirmed")]
    public bool IsConfirmed { get; set; }
}

public class Speaker
{

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("firstName")]
    public string FirstName { get; set; }

    [JsonPropertyName("lastName")]
    public string LastName { get; set; }

    [JsonPropertyName("bio")]
    public string Bio { get; set; }

    [JsonPropertyName("tagLine")]
    public string TagLine { get; set; }

    [JsonPropertyName("profilePicture")]
    public string ProfilePicture { get; set; }

    [JsonPropertyName("isTopSpeaker")]
    public bool IsTopSpeaker { get; set; }

    [JsonPropertyName("links")]
    public List<object> Links { get; set; }

    [JsonPropertyName("sessions")]
    public List<int> Sessions { get; set; }

    [JsonPropertyName("fullName")]
    public string FullName { get; set; }

    [JsonPropertyName("categoryItems")]
    public List<object> CategoryItems { get; set; }

    [JsonPropertyName("questionAnswers")]
    public List<object> QuestionAnswers { get; set; }
}

public class Room
{

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("sort")]
    public int Sort { get; set; }
}

public class SessionizeDaySchedule
{
    [JsonPropertyName("date")]
    public DateTime Date { get; set; }
    [JsonPropertyName("isDefault")]
    public bool IsDefault { get; set; }
    [JsonPropertyName("rooms")]
    public SessionizeRoomSchedule[] Rooms { get; set; }
}

public class SessionizeRoomSchedule
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("sessions")]
    public SessionizeRoomScheduleSession[] Sessions { get; set; }
    [JsonPropertyName("hasOnlyPlenumSessions")]
    public bool HasOnlyPlenumSessions { get; set; }
}

public class SessionizeRoomScheduleSession
{

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("startsAt")]
    public DateTime StartsAt { get; set; }

    [JsonPropertyName("endsAt")]
    public DateTime EndsAt { get; set; }

    [JsonPropertyName("isServiceSession")]
    public bool IsServiceSession { get; set; }

    [JsonPropertyName("isPlenumSession")]
    public bool IsPlenumSession { get; set; }

    [JsonPropertyName("speakers")]
    public SessionizeRoomScheduleSessionSpeaker[] Speakers { get; set; }

    [JsonPropertyName("categories")]
    public object[] Categories { get; set; }

    [JsonPropertyName("roomId")]
    public int RoomId { get; set; }

    [JsonPropertyName("room")]
    public string Room { get; set; }

    [JsonPropertyName("liveUrl")]
    public object LiveUrl { get; set; }

    [JsonPropertyName("recordingUrl")]
    public object RecordingUrl { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("isInformed")]
    public bool IsInformed { get; set; }

    [JsonPropertyName("isConfirmed")]
    public bool IsConfirmed { get; set; }
}

public class SessionizeRoomScheduleSessionSpeaker
{

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}

//public class Timeslot
//{
//    public string slotStart { get; set; }
//    public Room1[] rooms { get; set; }
//}

//public class Room1
//{
//    public int id { get; set; }
//    public string name { get; set; }
//    public Session1 session { get; set; }
//    public int index { get; set; }
//}

//public class Session1
//{
//    public string id { get; set; }
//    public string title { get; set; }
//    public string description { get; set; }
//    public DateTime startsAt { get; set; }
//    public DateTime endsAt { get; set; }
//    public bool isServiceSession { get; set; }
//    public bool isPlenumSession { get; set; }
//    public Speaker1[] speakers { get; set; }
//    public object[] categories { get; set; }
//    public int roomId { get; set; }
//    public string room { get; set; }
//    public object liveUrl { get; set; }
//    public object recordingUrl { get; set; }
//    public string status { get; set; }
//    public bool isInformed { get; set; }
//    public bool isConfirmed { get; set; }
//}

//public class Speaker1
//{
//    public string id { get; set; }
//    public string name { get; set; }
//}
