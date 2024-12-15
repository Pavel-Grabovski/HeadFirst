﻿namespace HeadFirst.StatePattern;

public class GumballMachineTestDrive
{
    public static void Start()
    {
        GumballMachine gumballMachine = new GumballMachine(5);
        Console.WriteLine(gumballMachine);

        gumballMachine.InsertQuarter();
        gumballMachine.TurnCrank();

        Console.WriteLine(gumballMachine);

        gumballMachine.InsertQuarter();
        gumballMachine.TurnCrank();
        gumballMachine.InsertQuarter();
        gumballMachine.TurnCrank();

        Console.WriteLine(gumballMachine);
    }
}