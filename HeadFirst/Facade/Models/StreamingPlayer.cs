
using System.Numerics;

namespace HeadFirst.Facade.Models;

public class StreamingPlayer
{
    internal void Off()
    {
        Console.WriteLine($"Streaming Player off");
    }

    internal void Play(string movie)
    {
        Console.WriteLine($"Streaming Player playing {movie}");
    }

    internal void Stop()
    {
        Console.WriteLine($"Streaming Player stop");
    }
}