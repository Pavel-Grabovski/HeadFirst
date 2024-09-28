namespace HeadFirst.Strategy.Duck;

public class MiniDuckSimulator
{
    public static void Start()
    {
        Duck mallard = new MallardDuck();

        mallard.PerformQuack();
        mallard.PerformFly();

        Duck model = new ModelDuck();
        model.PerformFly();

        mallard.SetFlyBehavior(new FlyRocketPowered());
        mallard.PerformFly();

    }
}