using HeadFirst.Factory.Ingredients.Cheese;
using HeadFirst.Factory.Ingredients.Clams;
using HeadFirst.Factory.Ingredients.Dough;
using HeadFirst.Factory.Ingredients.Pepperoni;
using HeadFirst.Factory.Ingredients.Sauce;
using HeadFirst.Factory.Ingredients.Veggies;

namespace HeadFirst.Factory.Pizzas;

public abstract class Pizza
{
    public string Name { get; set; }
    
    public IDough Dough { get; set; }

    public ISauce Sauce { get; set; }

    public IVegetable[] Veggies { get; set; }

    public ICheese Cheese;

    public IPepperoni Pepperoni;

    public IClam Clam;

    public List<string> toppings { get; set; } = new List<string>();

    public abstract void Prepare();

    public virtual void Bake()
    {
        Console.WriteLine("Bake for 25 minutes at 350");
    }

    public virtual void Cut()
    {
        Console.WriteLine("Cutting the pizza into diagonal slices");
    }

    public virtual void Box()
    {
        Console.WriteLine("Place pizza in official PizzaStore box");
    }

    public string GetName() => Name;

    public void SetName(string name)
    {
        Name = name;
    }
}   
