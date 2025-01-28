namespace HeadFirst.CompositionPatterns;

public class DuckSimulator
{
    public static void Start()
    {
        DuckSimulator simulator = new DuckSimulator();
        AbstractDuckFactory duckFactory = new CountingDuckFactory();
        simulator.Simulate(duckFactory);
    }

    void Simulate(AbstractDuckFactory duckFactory)
    {
        IQuackable mallardDuck = duckFactory.CreateMallardDuck();
        IQuackable redheadDuck = duckFactory.CreateRedheadDuck();
        IQuackable duckCall = duckFactory.CreateDuckCall();
        IQuackable rubberDuck = duckFactory.CreateRubberDuck();

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