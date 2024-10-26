using HeadFirst.Factory.Ingredients.Cheese;
using HeadFirst.Factory.Ingredients.Clams;
using HeadFirst.Factory.Ingredients.Dough;
using HeadFirst.Factory.Ingredients.Pepperoni;
using HeadFirst.Factory.Ingredients.Sauce;
using HeadFirst.Factory.Ingredients.Veggies;
namespace HeadFirst.Factory.IngredientFactory;

public interface IPizzaIngredientFactory
{
    public IDough CreateDough();
    public ISauce CreateSauce();
    public ICheese CreateCheese();
    public IVegetable[] CreateVeggies();
    public IPepperoni CreatePepperoni();
    public IClam CreateClam();
}
