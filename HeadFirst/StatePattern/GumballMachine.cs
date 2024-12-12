using HeadFirst.Commands.Models;
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

    public void InsertCoin()
    {
        if (_state == StateEnum.HAS_COIN)
        {
            Console.WriteLine("You can’t insert another quarter");
        }
        else if (_state == StateEnum.NO_COIN)
        {
            _state = StateEnum.HAS_COIN;
            Console.WriteLine("You inserted a quarter");
        }
        else if (_state == StateEnum.NO_BALLS)
        {
            Console.WriteLine("You can’t insert a quarter, the machine is sold out");
        }
        else if (_state == StateEnum.SOLD_BALS)
        {
            Console.WriteLine("Please wait, we’re already giving you a gumball");
        }
    }

    public void ReturnCoin()
    {
        if (_state == StateEnum.HAS_COIN)
        {
            Console.WriteLine("Quarter returned");
            _state = StateEnum.NO_COIN;
        }
        else if (_state == StateEnum.NO_COIN)
        {
            Console.WriteLine("You haven’t inserted a quarter");
        }
        else if (_state == StateEnum.SOLD_BALS)
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }
        else if (_state == StateEnum.NO_BALLS)
        {
            Console.WriteLine("You can’t eject, you haven’t inserted a quarter yet");
        }
    }

    public void TurnCrank()
    {
        if (_state == StateEnum.SOLD_BALS)
        {
            Console.WriteLine("Turning twice doesn’t get you another gumball!");
        }
        else if (_state == StateEnum.NO_COIN)
        {
            Console.WriteLine("You turned but there’s no quarter");
        }
        else if (_state == StateEnum.NO_BALLS)
        {
            Console.WriteLine("You turned, but there are no gumballs");
        }
        else if (_state == StateEnum.HAS_COIN)
        {
            Console.WriteLine("You turned...");
            _state = StateEnum.SOLD_BALS;
            Dispense();
        }
    }

    public void Dispense()
    {
        if (_state == StateEnum.SOLD_BALS)
        {
            Console.WriteLine("A gumball comes rolling out the slot");
            _count--;

            if (_count == 0)
            {
                Console.WriteLine("Oops, out of gumballs!");
                _state = StateEnum.NO_BALLS;
            }
            else
            {
                _state = StateEnum.NO_COIN;
            }
        }
        else if (_state == StateEnum.NO_COIN)
        {
            throw new Exception("You need to pay first");
        }
        else if (_state == StateEnum.NO_BALLS)
        {
            throw new Exception("No gumball dispensed");
        }
        else if (_state == StateEnum.HAS_COIN)
        {
            throw new Exception("No gumball dispensed");
        }
    }

    public override string ToString()
    {
        return "Mighty Gumball, Inc.\n" +
                "Standing Gumball Model #2004\n" +
                $"Inventory: {_count} gumballs\n" +
                "Machine is waiting for quarter\n";
    }

    internal object GetHasQuarterState()
    {
        throw new NotImplementedException();
    }

    internal void SetState(object v)
    {
        throw new NotImplementedException();
    }
}
