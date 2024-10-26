using HeadFirst.Factory.Ingredients;
using HeadFirst.Factory.Ingredients.Cheese;
using HeadFirst.Factory.Ingredients.Clams;
using HeadFirst.Factory.Ingredients.Sauce;
namespace HeadFirst.Factory;

public interface IPizzaIngredientFactory
{
    public IDough CreateDough();
    public ISauce CreateSauce();
    public ICheese CreateCheese();
    public IVegetable[] CreateVeggies();
    public IPepperoni CreatePepperoni();
    public IClam CreateClam();
}
