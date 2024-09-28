namespace HeadFirst.Strategy.Duck;

public class MallardDuck : Duck
{
    public MallardDuck()
    {
        QuackBehavior = new Quack();
        FlyBehavior = new FlyWithWings();
    }
}
