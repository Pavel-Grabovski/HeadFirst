﻿namespace HeadFirst.Commands.Models;

public class Light
{
    private readonly string _location;

    public Light(string location)
    {
        _location = location;
    }

    public void On()
    {
        Console.WriteLine($"{_location} light On");
    }

    public void Off()
    {
        Console.WriteLine($"{_location} light off");
    }
}