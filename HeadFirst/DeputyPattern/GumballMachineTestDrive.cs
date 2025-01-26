namespace HeadFirst.DeputyPattern;

public class GumballMachineTestDrive
{
    public static void Start()
    {
        int count = 0;

        GumballMachine gumballMachine = new GumballMachine("MSR", 112);
        GumballMonitor monitor = new GumballMonitor(gumballMachine);
        // Остальной код
        monitor.Report();

    }
}