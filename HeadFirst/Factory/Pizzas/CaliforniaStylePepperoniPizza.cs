namespace HeadFirst.Factory.Pizzas;

public class CaliforniaStylePepperoniPizza : Pizza
{
    private readonly IPizzaIngredientFactory _ingredientFactory;

    public CaliforniaStylePepperoniPizza(IPizzaIngredientFactory ingredientFactory)
    {
        _ingredientFactory = ingredientFactory;
    }

    public override void Bake()
    {
        Console.WriteLine("Bake pepperoni pizza in California style");
    }

    public override void Box()
    {
        Console.WriteLine("Box veggie pizza in California style");
    }

    public override void Cut()
    {
        Console.WriteLine("Cut pepperoni pizza in California style");
    }

    public override void Prepare()
    {
        Console.WriteLine($"Preparing {Name}");
        Dough = _ingredientFactory.CreateDough();
        Sauce = _ingredientFactory.CreateSauce();
        Cheese = _ingredientFactory.CreateCheese();
    }
}