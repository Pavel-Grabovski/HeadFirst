using HeadFirst.Factory.IngredientFactory;

namespace HeadFirst.Factory.Pizzas;

public class NYStyleCheesePizza : Pizza
{
    private readonly IPizzaIngredientFactory _ingredientFactory;

    public NYStyleCheesePizza(IPizzaIngredientFactory ingredientFactory)
    {
        _ingredientFactory = ingredientFactory;
    }

    public override void Bake()
    {
        Console.WriteLine("Bake cheese pizza in NY style");
    }

    public override void Box()
    {
        Console.WriteLine("Box cheese pizza in NY style");
    }

    public override void Cut()
    {
        Console.WriteLine("Cut cheese pizza in NY style");
    }

    public override void Prepare()
    {
        Console.WriteLine($"Preparing {Name}");
        Dough = _ingredientFactory.CreateDough();
        Sauce = _ingredientFactory.CreateSauce();
        Cheese = _ingredientFactory.CreateCheese();
    }
}