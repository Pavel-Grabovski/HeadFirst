using HeadFirst.StatePattern.States;

namespace HeadFirst.StatePattern;

public class GumballMachine
{
    private readonly IState _soldOutState;
    private readonly IState _noQuarterState;
    private readonly IState _hasQuarterState;
    private readonly IState _soldState;
    private readonly IState _winnerState;

    private IState _state;

    private int _count = 0;

    public GumballMachine(int count)
    {
        _count = count;

        _soldOutState = new SoldOutState(this);
        _noQuarterState = new NoQuarterState(this);
        _hasQuarterState = new HasQuarterState(this);
        _soldState = new SoldState(this);
        _winnerState = new WinnerState(this);


        if (count > 0)
            _state = _noQuarterState;
        else 
            _state = _soldOutState;
    }


    public void InsertQuarter()
    {
        _state.InsertQuarter();
    }

    public void EjectQuarter()
    {
        _state.EjectQuarter();
    }

    public void TurnCrank()
    {
        _state.TurnCrank();
        _state.Dispense();
    }

    public void SetState(IState state)
    {
        _state = state;
    }

    public void ReleaseBall()
    {
        Console.WriteLine("A gumball comes rolling out the slot...");
        if (_count != 0)
            _count--;
    }

    public void Refill(int count)
    {
        _count += count;
        Console.WriteLine("The gumball machine was just refilled; it's new count is: " + _count);
        _state.Refill();
    }

    public override string ToString()
    {
        return "Mighty Gumball, Inc.\n" +
                "Standing Gumball Model #2004\n" +
                $"Inventory: {_count} gumballs\n" +
                "Machine is waiting for quarter\n";
    }

    public IState GetNoQuarterState() 
        => _noQuarterState;
    
    public IState GetHasQuarterState() 
        => _hasQuarterState;

    public IState GetSoldState()
        => _soldState;

    public IState GetSoldOutState()
        => _soldOutState;

    public IState GetWinnerState()
        => _winnerState;

    public int GetCount() 
        => _count;
}
