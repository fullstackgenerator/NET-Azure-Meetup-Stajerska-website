public class SessionizeResponse
{
    public List<Session> Sessions { get; set; } = new();
    public List<Speaker> Speakers { get; set; } = new();
}

public class Session
{
    public string Id { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<string> Speakers { get; set; } = new();
}

public class Speaker
{
    public string Id { get; set; } = string.Empty;
    public string FullName { get; set; } = string.Empty;
    public string TagLine { get; set; } = string.Empty;
    public string Bio { get; set; } = string.Empty;
    public string ProfilePicture { get; set; } = string.Empty;
    public List<int> Sessions { get; set; } = new();
}