﻿namespace HeadFirst.Commands;

public class Stereo
{
    private readonly string _name;

    public Stereo(string name)
    {
        _name = name;
    }

    public void On()
    {
        Console.WriteLine("Stereo on");
    }

    public void Off()
    {
        Console.WriteLine("Stereo off");
    }

    public void SetCD()
    {
        Console.WriteLine("Stereo set cd");
    }

    public void SetVolume(int volume)
    {
        Console.WriteLine($"Stereo set volume {volume}");
    }
}
