using HeadFirst.Factory.Ingredients;
namespace HeadFirst.Factory;

public interface IPizzaIngredientFactory
{
    public IDough CreateDough();
    public Sauce CreateSauce();
    public Cheese CreateCheese();
    public Vegetable[] CreateVeggies();
    public Pepperoni CreatePepperoni();
    public IClams CreateClam();
}
