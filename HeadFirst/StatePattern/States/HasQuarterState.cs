﻿namespace HeadFirst.StatePattern.States;

/// <summary>
/// Монета брошена
/// </summary>
public class HasQuarterState : IState
{
    private readonly GumballMachine _gumballMachine;

    public HasQuarterState(GumballMachine gumballMachine)
    {
        _gumballMachine = gumballMachine;
    }

    public void Dispense()
    {
        Console.WriteLine("No gumball dispensed");
    }

    public void EjectQuarter()
    {
        Console.WriteLine("Quarter returned");
        _gumballMachine.SetState(_gumballMachine.GetNoQuarterState());
    }

    public void InsertQuarter()
    {
        Console.WriteLine("You can’t insert another quarter");
    }

    public void TurnCrank()
    {
        Console.WriteLine("You turned...");
        _gumballMachine.SetState(_gumballMachine.GetSoldState());
    }
}