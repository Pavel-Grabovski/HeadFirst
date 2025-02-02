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
        IQuackable redheadDuck = duckFactory.CreateRedheadDuck();
        IQuackable duckCall = duckFactory.CreateDuckCall();
        IQuackable rubberDuck = duckFactory.CreateRubberDuck();
        IQuackable gooseDuck = new GooseAdapter(new Goose());
        Console.WriteLine("\nDuck Simulator: With Composite — Flocks");

        Flock flockOfDucks = new Flock();
        
        flockOfDucks.Add(redheadDuck);
        flockOfDucks.Add(duckCall);
        flockOfDucks.Add(rubberDuck);
        flockOfDucks.Add(gooseDuck);

        Flock flockOfMallards = new Flock();

        IQuackable mallardOne = duckFactory.CreateMallardDuck();
        IQuackable mallardTwo = duckFactory.CreateMallardDuck();
        IQuackable mallardThree = duckFactory.CreateMallardDuck();
        IQuackable mallardFour = duckFactory.CreateMallardDuck();

        flockOfMallards.Add(mallardOne);
        flockOfMallards.Add(mallardTwo);
        flockOfMallards.Add(mallardThree);
        flockOfMallards.Add(mallardFour);

        flockOfDucks.Add(flockOfMallards);

        Console.WriteLine("\nDuck Simulator: Whole Flock Simulation");
        Simulate(flockOfDucks);
        Console.WriteLine("\nDuck Simulator: Mallard Flock Simulation");
        Simulate(flockOfMallards);
       
        Console.WriteLine("The ducks quacked " + QuackCounter.GetQuacks() + " times");
    }

    void Simulate(IQuackable duck)
    {
        duck.Quack();
    }
}