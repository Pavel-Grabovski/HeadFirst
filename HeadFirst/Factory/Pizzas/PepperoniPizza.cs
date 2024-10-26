using HeadFirst.Factory.IngredientFactory;

namespace HeadFirst.Factory.Pizzas;

public class PepperoniPizza : Pizza
{
    private readonly IPizzaIngredientFactory _ingredientFactory;

    public PepperoniPizza(IPizzaIngredientFactory ingredientFactory)
    {
        _ingredientFactory = ingredientFactory;
    }

    public override void Bake()
    {
        Console.WriteLine("Bake pepperoni pizza");
    }

    public override void Box()
    {
        Console.WriteLine("Box pepperoni pizza");
    }

    public override void Cut()
    {
        Console.WriteLine("Cut pepperoni pizza");
    }

    public override void Prepare()
    {
        Console.WriteLine($"Preparing {Name}");
        Dough = _ingredientFactory.CreateDough();
        Sauce = _ingredientFactory.CreateSauce();
        Cheese = _ingredientFactory.CreateCheese();
    }
}
