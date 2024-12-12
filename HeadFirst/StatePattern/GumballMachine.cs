﻿using HeadFirst.Commands.Models;
using System.Reflection.PortableExecutable;
using System.Reflection;
using HeadFirst.StatePattern.States;

namespace HeadFirst.StatePattern;

public class GumballMachine
{
    private readonly IState _soldOutState;
    private readonly IState _noQuarterState;
    private readonly IState _hasQuarterState;
    private readonly IState _soldState;

    private IState _state = _soldOutState;

    private int _count = 0;

    public GumballMachine(int count)
    {
        _count = count;

        _soldOutState = new SoldOutState(this);
        _noQuarterState = new NoQuarterState(this);
        _hasQuarterState = new HasQuarterState(this);
        _soldState = new SoldState(this);


        if (count > 0)
            _state = _noQuarterState;
        else 
            _state = _soldOutState;
    }


    public void InsertQuarter()
    {
        _state.InsertQuarter();
    }

    public void ejectQuarter()
    {
        _state.EjectQuarter();
    }

    public void turnCrank()
    {
        _state.TurnCrank();
        _state.Dispense();
    }

    internal void SetState(IState state)
    {
        _state = state;
    }

    internal void ReleaseBall()
    {
        Console.WriteLine("A gumball comes rolling out the slot...");
        if (_count != 0)
            _count--;
    }



    public override string ToString()
    {
        return "Mighty Gumball, Inc.\n" +
                "Standing Gumball Model #2004\n" +
                $"Inventory: {_count} gumballs\n" +
                "Machine is waiting for quarter\n";
    }

    internal IState GetHasQuarterState() 
        => _hasQuarterState;

    public int GetCount() 
        => _count;
}
