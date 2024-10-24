﻿namespace HeadFirst.Factory.Pizzas;

public class ChicagoStyleClamPizza : Pizza
{
    private readonly IPizzaIngredientFactory _ingredientFactory;

    public ChicagoStyleClamPizza(IPizzaIngredientFactory ingredientFactory)
    {
        _ingredientFactory = ingredientFactory;
    }

    public override void Bake()
    {
        Console.WriteLine("Bake clam pizza in Chicago style");
    }

    public override void Box()
    {
        Console.WriteLine("Box clam pizza in Chicago style");
    }

    public override void Cut()
    {
        Console.WriteLine("Cut clam pizza in Chicago style");
    }

    public override void Prepare()
    {
        Console.WriteLine($"Preparing {Name}");
        Dough = _ingredientFactory.CreateDough();
        Sauce = _ingredientFactory.CreateSauce();
        Cheese = _ingredientFactory.CreateCheese();
    }
}