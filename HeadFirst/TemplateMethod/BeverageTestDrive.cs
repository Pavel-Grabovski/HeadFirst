namespace HeadFirst.TemplateMethod;

public class BeverageTestDrive
{
    public static void Start()
    {
        CoffeeWithHook coffeeWithHook = new();
        coffeeWithHook.PrepareRecipe();

        Console.WriteLine();

        TeaWithHook teaWithHook = new();
        teaWithHook.PrepareRecipe();
    }
}
