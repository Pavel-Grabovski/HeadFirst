using HeadFirst.Adapter.Models;

namespace HeadFirst.Adapter;

public class DuckTestDrive
{
    public static void Start()
    {
        IDuck duck = new MallardDuck();

        ITurkey turkey = new WildTurkey();
        IDuck turkeyAdapter = new TurkeyAdapter(turkey);

        Console.WriteLine("The Turkey says...");
        turkey.Gobble();
        turkey.Fly();

        Console.WriteLine("\nThe Duck says...");
        testDuck(duck);

        Console.WriteLine("\nThe TurkeyAdapter says...");
        testDuck(turkeyAdapter);
    }

    static void testDuck(IDuck duck)
    {
        duck.Quack();
        duck.Fly();
    }
}
