namespace PlayerMP3.Models;

public class MusicInfo
{
    public required string Name { get; set; }

    public required string Path { get; set; }

    public TimeSpan PlayingTime { get; set; }
}
