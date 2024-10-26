using HeadFirst.Factory.Ingredients.Cheese;
using HeadFirst.Factory.Ingredients.Clams;
using HeadFirst.Factory.Ingredients.Dough;
using HeadFirst.Factory.Ingredients.Pepperoni;
using HeadFirst.Factory.Ingredients.Sauce;
using HeadFirst.Factory.Ingredients.Veggies;
namespace HeadFirst.Factory.IngredientFactory;

public class CaliforniaPizzaIngredientFactory : IPizzaIngredientFactory
{
    public ICheese CreateCheese()
    {
        return new GoatCheese();
    }

    public IClam CreateClam()
    {
        return new Calamari();
    }

    public IDough CreateDough()
    {
        return new VeryThinCrust();
    }

    public IPepperoni CreatePepperoni()
    {
        return new SlicedPepperoni();
    }

    public ISauce CreateSauce()
    {
        return new BruschettaSauce();
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

