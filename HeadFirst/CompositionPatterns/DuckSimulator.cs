namespace HeadFirst.CompositionPatterns;

public class DuckSimulator
{
    public static void Start()
    {
        DuckSimulator simulator = new DuckSimulator();
        simulator.Simulate();
    }

    void Simulate()
    {
        IQuackable mallardDuck = new QuackCounter(new MallardDuck());
        IQuackable redheadDuck = new QuackCounter(new RedheadDuck());
        IQuackable duckCall = new QuackCounter(new DuckCall());
        IQuackable rubberDuck = new QuackCounter(new RubberDuck());
        IQuackable gooseDuck = new GooseAdapter(new Goose());

        Console.WriteLine("\nDuck Simulator");
        Simulate(mallardDuck);
        Simulate(redheadDuck);
        Simulate(duckCall);
        Simulate(rubberDuck);
        Simulate(gooseDuck);

        Console.WriteLine("The ducks quacked " + QuackCounter.GetQuacks() + " times");
    }

    void Simulate(IQuackable duck)
    {
        duck.Quack();
    }
}