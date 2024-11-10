namespace HeadFirst.Commands;

public class Stereo
{
    private readonly string _location;

    public Stereo(string location)
    {
        _location = location;
    }

    public void On()
    {
        Console.WriteLine($"{_location} stereo on");
    }

    public void Off()
    {
        Console.WriteLine($"{_location} stereo off");
    }

    public void SetCD()
    {
        Console.WriteLine($"{_location} stereo set cd");
    }

    public void SetVolume(int volume)
    {
        Console.WriteLine($"Stereo set volume {volume}");
    }
}
