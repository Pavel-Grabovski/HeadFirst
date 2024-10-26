using HeadFirst.Factory.IngredientFactory;

namespace HeadFirst.Factory.Pizzas;

public class NYStylePepperoniPizza : Pizza
{
    private readonly IPizzaIngredientFactory _ingredientFactory;

    public NYStylePepperoniPizza(IPizzaIngredientFactory ingredientFactory)
    {
        _ingredientFactory = ingredientFactory;
    }

    public override void Bake()
    {
        Console.WriteLine("Bake pepperoni pizza in NY style");
    }

    public override void Box()
    {
        Console.WriteLine("Box pepperoni pizza in NY style");
    }

    public override void Cut()
    {
        Console.WriteLine("Cut pepperoni pizza in NY style");
    }

    public override void Prepare()
    {
        Console.WriteLine($"Preparing {Name}");
        Dough = _ingredientFactory.CreateDough();
        Sauce = _ingredientFactory.CreateSauce();
        Cheese = _ingredientFactory.CreateCheese();
    }
}