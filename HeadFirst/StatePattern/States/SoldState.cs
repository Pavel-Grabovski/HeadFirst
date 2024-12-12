namespace HeadFirst.StatePattern.States;

/// <summary>
/// Выдача шарика
/// </summary>
public class SoldState : IState
{
    private readonly GumballMachine _gumballMachine;

    public SoldState(GumballMachine gumballMachine)
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
