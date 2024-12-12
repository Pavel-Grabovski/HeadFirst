namespace HeadFirst.StatePattern.States;

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
