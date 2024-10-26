using HeadFirst.Factory.Ingredients;
namespace HeadFirst.Factory;

public class NYPizzaIngredientFactory : IPizzaIngredientFactory
{
    public Cheese CreateCheese()
    {
        throw new NotImplementedException();
    }

    public Clams CreateClam()
    {
        throw new NotImplementedException();
    }

    public IDough CreateDough()
    {
        throw new NotImplementedException();
    }

    public Pepperoni CreatePepperoni()
    {
        throw new NotImplementedException();
    }

    public Sauce CreateSauce()
    {
        throw new NotImplementedException();
    }

    public Vegetable[] CreateVeggies()
    {
        throw new NotImplementedException();
    }
}
