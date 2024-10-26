using HeadFirst.Factory.Ingredients;

namespace HeadFirst.Factory.Pizzas;

public abstract class Pizza
{
    public string Name { get; set; }
    
    public IDough Dough { get; set; }

    public ISauce Sauce { get; set; }

    public IVegetable[] Veggies { get; set; }

    public Cheese Cheese;

    public IPepperoni Pepperoni;

    public IClams Clam;

    public List<string> toppings { get; set; } = new List<string>();

    public abstract void Prepare();

    public abstract void Bake();

    public abstract void Cut();

    public abstract void Box();

    public string GetName() => Name;

    public void SetName(string name)
    {
        Name = name;
    }
}   
