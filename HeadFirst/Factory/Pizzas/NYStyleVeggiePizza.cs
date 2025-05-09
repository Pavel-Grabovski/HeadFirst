﻿using HeadFirst.Factory.IngredientFactory;

namespace HeadFirst.Factory.Pizzas;

public class NYStyleVeggiePizza : Pizza
{
    private readonly IPizzaIngredientFactory _ingredientFactory;

    public NYStyleVeggiePizza(IPizzaIngredientFactory ingredientFactory)
    {
        _ingredientFactory = ingredientFactory;
    }

    public override void Bake()
    {
        Console.WriteLine("Bake veggie pizza in NY style");
    }

    public override void Box()
    {
        Console.WriteLine("Box veggie pizza in NY style");
    }

    public override void Cut()
    {
        Console.WriteLine("Cut veggie pizza in NY style");
    }

    public override void Prepare()
    {
        Console.WriteLine($"Preparing {Name}");
        Dough = _ingredientFactory.CreateDough();
        Sauce = _ingredientFactory.CreateSauce();
        Cheese = _ingredientFactory.CreateCheese();
    }
}