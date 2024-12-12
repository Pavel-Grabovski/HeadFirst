namespace HeadFirst.StatePattern.States;

/// <summary>
/// В автомате нет шариков
/// </summary>
public class SoldOutState : IState
{
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
