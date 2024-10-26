using HeadFirst.Factory.Ingredients.Cheese;
using HeadFirst.Factory.Ingredients.Clams;
using HeadFirst.Factory.Ingredients.Dough;
using HeadFirst.Factory.Ingredients.Pepperoni;
using HeadFirst.Factory.Ingredients.Sauce;
using HeadFirst.Factory.Ingredients.Veggies;
namespace HeadFirst.Factory.IngredientFactory;

public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
{
    public ICheese CreateCheese()
    {
        return new MozzarellaCheese();
    }

    public IClam CreateClam()
    {
        return new FrozenClam();
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
        return new PlumTomatoSauce();
    }

    public IVegetable[] CreateVeggies()
    {
        return new IVegetable[]
        {
            new Spinach(),
            new BlackOlives(),
            new EggPlant()
        };
    }
}

