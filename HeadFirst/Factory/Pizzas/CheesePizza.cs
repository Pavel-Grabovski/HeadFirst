namespace HeadFirst.Factory.Pizzas;

public class CheesePizza : Pizza
{
    private readonly IPizzaIngredientFactory _ingredientFactory;

    public CheesePizza(IPizzaIngredientFactory ingredientFactory)
    {
        _ingredientFactory = ingredientFactory;
    }

    public override void Bake()
    {
        Console.WriteLine("Bake cheese pizza");
    }

    public override void Box()
    {
        Console.WriteLine("Box cheese pizza");
    }

    public override void Cut()
    {
        Console.WriteLine("Cut cheese pizza");
    }

    public override void Prepare()
    {
        Console.WriteLine($"Preparing {Name}");
        Dough = _ingredientFactory.CreateDough();
        Sauce = _ingredientFactory.CreateSauce();
        Cheese = _ingredientFactory.CreateCheese();
    }
}
