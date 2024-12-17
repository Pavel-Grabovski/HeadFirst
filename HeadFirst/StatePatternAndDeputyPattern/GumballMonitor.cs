﻿using HeadFirst.StatePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirst.StatePatternAndDeputyPattern;

public class GumballMonitor
{
    private readonly GumballMachine _machine;

    public GumballMonitor(GumballMachine machine)
    {
        _machine = machine;
    }

    public void Report()
    {
        Console.WriteLine("Gumball Machine: " + _machine.GetLocation());
        Console.WriteLine("Current inventory: " + _machine.GetCount() + " gumballs");
        Console.WriteLine("Current state: " + _machine.GetState());
    }

}