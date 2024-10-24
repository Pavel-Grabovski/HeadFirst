﻿using HeadFirst.Factory.Ingredients;
namespace HeadFirst.Factory;

public interface IPizzaIngredientFactory
{
    public Dough CreateDough();
    public Sauce CreateSauce();
    public Cheese CreateCheese();
    public Vegetable[] CreateVeggies();
    public Pepperoni CreatePepperoni();
    public Clams CreateClam();
}
