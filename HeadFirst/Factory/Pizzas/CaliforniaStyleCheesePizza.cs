using HeadFirst.Factory.IngredientFactory;

namespace HeadFirst.Factory.Pizzas;

public class CaliforniaStyleCheesePizza : Pizza
{
    private readonly IPizzaIngredientFactory _ingredientFactory;

    public CaliforniaStyleCheesePizza(IPizzaIngredientFactory ingredientFactory)
    {
        _ingredientFactory = ingredientFactory;
    }

    public override void Bake()
    {
        Console.WriteLine("Bake cheese pizza in California style");
    }

    public override void Box()
    {
        Console.WriteLine("Box cheese pizza in California style");
    }

    public override void Cut()
    {
        Console.WriteLine("Cut cheese pizza in California style");
    }

    public override void Prepare()
    {
        Console.WriteLine($"Preparing {Name}");
        Dough = _ingredientFactory.CreateDough();
        Sauce = _ingredientFactory.CreateSauce();
        Cheese = _ingredientFactory.CreateCheese();
    }
}