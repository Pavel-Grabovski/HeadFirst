namespace HeadFirst.Factory.Pizzas;

public class VeggiePizza : Pizza
{
    private readonly IPizzaIngredientFactory _ingredientFactory;

    public VeggiePizza(IPizzaIngredientFactory ingredientFactory)
    {
        _ingredientFactory = ingredientFactory;
    }

    public override void Bake()
    {
        Console.WriteLine("Bake veggie pizza");
    }

    public override void Box()
    {
        Console.WriteLine("Box veggie pizza");
    }

    public override void Cut()
    {
        Console.WriteLine("Cut veggie pizza");
    }

    public override void Prepare()
    {
        Console.WriteLine($"Preparing {Name}");
        Dough = _ingredientFactory.CreateDough();
        Sauce = _ingredientFactory.CreateSauce();
        Cheese = _ingredientFactory.CreateCheese();
    }
}