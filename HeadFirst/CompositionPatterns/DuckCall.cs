namespace HeadFirst.CompositionPatterns;

public class DuckCall : IQuackable
{
    public void Quack()
    {
        Console.WriteLine("Kwak");
    }
}
