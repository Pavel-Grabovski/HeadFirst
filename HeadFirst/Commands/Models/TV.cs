namespace HeadFirst.Commands.Models;

public class TV
{
    private readonly string _location;

    public TV(string location)
    {
        _location = location;
    }

    public void On()
    {
        Console.WriteLine($"{_location} TV on");
    }

    public void Off()
    {
        Console.WriteLine($"{_location} TV off");
    }
}