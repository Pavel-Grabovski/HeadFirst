namespace HeadFirst.Commands.Models;

public class CeilingFan
{
    private readonly string _location;

    private SpeedEnum _speed;

    public CeilingFan(string location)
    {
        _location = location;
    }

    public void On()
    {
        Console.WriteLine("Ceiling fan on");
    }

    public void Off()
    {
        Console.WriteLine("Ceiling fan off");
    }

    public void SetSpeed(SpeedEnum speed)
    {
        _speed = speed;
    }

    public SpeedEnum GetSpeed()
    {
        return _speed;
    }

}
