
namespace HeadFirst.Facade.Models;

public class Amplifier
{
    public void On()
    {
        Console.WriteLine("Amplifier on");
    }

    public void Off()
    {
        Console.WriteLine("Amplifier off");
    }

    internal void SetStreamingPlayer(StreamingPlayer player)
    {
        Console.WriteLine($"Amplifier settings StreamingPlayer player to {player}");
    }

    internal void SetSurroundSound()
    {
       Console.WriteLine($"Amplifier surround sound on (5 speakers, 1 subwoofer)");
    }

    internal void SetVolume(int v)
    {
        Console.WriteLine($"Amplifier settings volume to {v}%");
    }
}