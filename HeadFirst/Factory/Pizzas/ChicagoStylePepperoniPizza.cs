namespace HeadFirst.Factory.Pizzas;

public class ChicagoStylePepperoniPizza : Pizza
{
    private readonly IPizzaIngredientFactory _ingredientFactory;

    public ChicagoStylePepperoniPizza(IPizzaIngredientFactory ingredientFactory)
    {
        _ingredientFactory = ingredientFactory;
    }

    public override void Bake()
    {
        Console.WriteLine("Bake pepperoni pizza in Chicago style");
    }

    public override void Box()
    {
        Console.WriteLine("Box pepperoni pizza in Chicago style");
    }

    public override void Cut()
    {
        Console.WriteLine("Cut pepperoni pizza in Chicago style");
    }

    public override void Prepare()
    {
        Console.WriteLine($"Preparing {Name}");
        Dough = _ingredientFactory.CreateDough();
        Sauce = _ingredientFactory.CreateSauce();
        Cheese = _ingredientFactory.CreateCheese();
    }
}