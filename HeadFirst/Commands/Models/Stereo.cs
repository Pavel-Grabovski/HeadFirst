namespace HeadFirst.Commands;

public class Stereo
{
    private readonly string _name;

    public Stereo(string name)
    {
        _name = name;
    }

    public void On()
    {
        Console.WriteLine("On");
    }

    public void SetCD()
    {
        throw new NotImplementedException();
    }

    public void SetVolume(int volume)
    {
        throw new NotImplementedException();
    }
}
