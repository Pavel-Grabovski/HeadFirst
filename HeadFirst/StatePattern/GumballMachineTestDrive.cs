namespace HeadFirst.StatePattern;

public class GumballMachineTestDrive
{
    public static void Start()
    {
        GumballMachine gumballMachine = new GumballMachine(5);
        Console.WriteLine(gumballMachine);
        gumballMachine.insertQuarter();
        gumballMachine.TurnCrank();
        Console.WriteLine(gumballMachine);
        gumballMachine.insertQuarter();
        gumballMachine.ReturnCoin();
        gumballMachine.TurnCrank();
        Console.WriteLine(gumballMachine);
        gumballMachine.insertQuarter();
        gumballMachine.TurnCrank();
        gumballMachine.insertQuarter();
        gumballMachine.TurnCrank();
        gumballMachine.ReturnCoin();
        Console.WriteLine(gumballMachine);
        gumballMachine.insertQuarter();
        gumballMachine.insertQuarter();
        gumballMachine.TurnCrank();
        gumballMachine.insertQuarter();
        gumballMachine.TurnCrank();
        gumballMachine.insertQuarter();
        gumballMachine.TurnCrank();
        Console.WriteLine(gumballMachine);
    }
}