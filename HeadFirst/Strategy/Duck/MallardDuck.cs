namespace HeadFirst.Strategy.Duck;

public class MallardDuck : Duck
{
    public MallardDuck()
    {
        QuackBehavior = new Quack();
        FlyBehavior = new FlyWithWings();
    }

    public override void Display()
    {
        Console.WriteLine("I 'm a real Mallard duck!");
    }
}
