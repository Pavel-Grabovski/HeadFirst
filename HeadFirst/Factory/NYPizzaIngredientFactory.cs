﻿using HeadFirst.Factory.Ingredients;
using HeadFirst.Factory.Ingredients.Cheese;
using HeadFirst.Factory.Ingredients.Clams;
using HeadFirst.Factory.Ingredients.Sauce;
namespace HeadFirst.Factory;

public class NYPizzaIngredientFactory : IPizzaIngredientFactory
{
    public ICheese CreateCheese()
    {
        throw new NotImplementedException();
    }

    public IClam CreateClam()
    {
        throw new NotImplementedException();
    }

    public IDough CreateDough()
    {
        throw new NotImplementedException();
    }

    public IPepperoni CreatePepperoni()
    {
        throw new NotImplementedException();
    }

    public ISauce CreateSauce()
    {
        throw new NotImplementedException();
    }

    public IVegetable[] CreateVeggies()
    {
        throw new NotImplementedException();
    }
}
