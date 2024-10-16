namespace HeadFirst.Factory.Pizzas;

public abstract class Pizza
{
    public string Name { get; set; }
    
    public string Dough { get; set; }

    public string Sauce { get; set; }

    public List<string> toppings { get; set; } = new List<string>();

    public abstract void Prepare();

    public abstract void Bake();

    public abstract void Cut();

    public abstract void Box();
}
