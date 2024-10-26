using HeadFirst.Factory.Ingredients.Cheese;
using HeadFirst.Factory.Ingredients.Clams;
using HeadFirst.Factory.Ingredients.Dough;
using HeadFirst.Factory.Ingredients.Pepperoni;
using HeadFirst.Factory.Ingredients.Sauce;
using HeadFirst.Factory.Ingredients.Veggies;
namespace HeadFirst.Factory;

public class NYPizzaIngredientFactory : IPizzaIngredientFactory
{
    public ICheese CreateCheese()
    {
         return new ReggianoCheese();
    }

    public IClam CreateClam()
    {
        return new FreshClam();
    }

    public IDough CreateDough()
    {
        return new ThinCrustDough();
    }

    public IPepperoni CreatePepperoni()
    {
        return new SlicedPepperoni();
    }

    public ISauce CreateSauce()
    {
        return new MarinaraSauce();
    }

    public IVegetable[] CreateVeggies()
    {
        return new IVegetable[]
        {
            new Garlic(),
            new Onion(),
            new Mushroom(),
            new RedPeppers()
        };
    }
}
