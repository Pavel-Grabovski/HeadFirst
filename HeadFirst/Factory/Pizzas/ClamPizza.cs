﻿using HeadFirst.Factory.IngredientFactory;

namespace HeadFirst.Factory.Pizzas;

public class ClamPizza : Pizza
{
    private readonly IPizzaIngredientFactory _ingredientFactory;

    public ClamPizza(IPizzaIngredientFactory ingredientFactory)
    {
        _ingredientFactory = ingredientFactory;
    }

    public override void Bake()
    {
        Console.WriteLine("Bake clam pizza");
    }

    public override void Box()
    {
        Console.WriteLine("Box clam pizza");
    }

    public override void Cut()
    {
        Console.WriteLine("Cut clam pizza");
    }

    public override void Prepare()
    {
        Console.WriteLine($"Preparing {Name}");

        Dough = _ingredientFactory.CreateDough();
        Sauce = _ingredientFactory.CreateSauce();
        Cheese = _ingredientFactory.CreateCheese();
        Clam = _ingredientFactory.CreateClam();
    }
}