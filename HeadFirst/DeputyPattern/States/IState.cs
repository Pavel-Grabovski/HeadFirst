namespace HeadFirst.DeputyPattern.States;

public interface IState
{
    public void Dispense();
    public void EjectQuarter();
    public void InsertQuarter();
    public void TurnCrank();
    public void Refill();
}
