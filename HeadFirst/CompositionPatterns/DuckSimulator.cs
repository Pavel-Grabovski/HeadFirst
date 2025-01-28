using HeadFirst.Strategy.Duck;

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
        IQuackable mallardDuck = new MallardDuck();
        IQuackable redheadDuck = new RedheadDuck();
        IQuackable duckCall = new DuckCall();
        IQuackable rubberDuck = new RubberDuck();
        IQuackable gooseDuck = new GooseAdapter(new Goose());

        Console.WriteLine("\nDuck Simulator");
        Simulate(mallardDuck);
        Simulate(redheadDuck);
        Simulate(duckCall);
        Simulate(rubberDuck);
        Simulate(gooseDuck);
    }

    void Simulate(IQuackable duck)
    {
        duck.Quack();
    }
}