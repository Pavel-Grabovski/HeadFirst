﻿namespace HeadFirst.StatePattern.States;

/// <summary>
/// В автомате нет шариков
/// </summary>
public class SoldOutState : IState
{
    private readonly GumballMachine _gumballMachine;

    public SoldOutState(GumballMachine gumballMachine)
    {
        _gumballMachine = gumballMachine;
    }

    public void Dispense()
    {
        Console.WriteLine("No gumball dispensed");
    }

    public void EjectQuarter()
    {
        Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
    }

    public void InsertQuarter()
    {
        Console.WriteLine("You can't insert a quarter, the machine is sold out");
    }

    public void Refill()
    {
        _gumballMachine.SetState(_gumballMachine.GetNoQuarterState());
    }

    public void TurnCrank()
    {
        Console.WriteLine("You turned, but there are no gumballs");
    }
}
