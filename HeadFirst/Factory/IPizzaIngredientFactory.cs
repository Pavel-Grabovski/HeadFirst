using HeadFirst.Factory.Ingredients;
namespace HeadFirst.Factory;

public interface IPizzaIngredientFactory
{
    public IDough CreateDough();
    public ISauce CreateSauce();
    public Cheese CreateCheese();
    public Vegetable[] CreateVeggies();
    public IPepperoni CreatePepperoni();
    public IClams CreateClam();
}
