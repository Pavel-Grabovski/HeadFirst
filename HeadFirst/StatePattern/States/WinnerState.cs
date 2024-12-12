namespace HeadFirst.StatePattern.States;

public class WinnerState : IState
{
    private readonly GumballMachine _gumballMachine;

    public WinnerState(GumballMachine gumballMachine)
    {
        _gumballMachine = gumballMachine;
    }

    public void Dispense()
    {
        throw new NotImplementedException();
    }

    public void EjectQuarter()
    {
        throw new NotImplementedException();
    }

    public void InsertQuarter()
    {
        throw new NotImplementedException();
    }

    public void TurnCrank()
    {
        throw new NotImplementedException();
    }
}
