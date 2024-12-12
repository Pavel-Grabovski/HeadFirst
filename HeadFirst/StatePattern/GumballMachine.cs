using HeadFirst.Commands.Models;
using System.Reflection.PortableExecutable;
using System.Reflection;

namespace HeadFirst.StatePattern;

public class GumballMachine
{
    private StateEnum _state = StateEnum.NO_BALLS;

    private int _countBalls = 0;

    public GumballMachine(int count)
    {
        _countBalls = count;

        if (count > 0)
            _state = StateEnum.NO_COIN;
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
            _countBalls--;

            if (_countBalls == 0)
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
                $"Inventory: {_countBalls} gumballs\n" +
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
