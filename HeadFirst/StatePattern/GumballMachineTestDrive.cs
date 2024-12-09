namespace HeadFirst.StatePattern;

public class GumballMachineTestDrive
{
    public static void Start()
    {
        GumballMachine gumballMachine = new GumballMachine(5);
        Console.WriteLine(gumballMachine);
        gumballMachine.InsertCoin();
        gumballMachine.TurnCrank();
        Console.WriteLine(gumballMachine);
        gumballMachine.InsertCoin();
        gumballMachine.ReturnCoin();
        gumballMachine.TurnCrank();
        Console.WriteLine(gumballMachine);
        gumballMachine.InsertCoin();
        gumballMachine.TurnCrank();
        gumballMachine.InsertCoin();
        gumballMachine.TurnCrank();
        gumballMachine.ReturnCoin();
        Console.WriteLine(gumballMachine);
        gumballMachine.InsertCoin();
        gumballMachine.InsertCoin();
        gumballMachine.TurnCrank();
        gumballMachine.InsertCoin();
        gumballMachine.TurnCrank();
        gumballMachine.InsertCoin();
        gumballMachine.TurnCrank();
        Console.WriteLine(gumballMachine);
    }
}