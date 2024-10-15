namespace HeadFirst.Factory;

public class SimplePizzaFactory
{
    public Pizza CreatePizza(PizzaTypeEnum type)
    {
        Pizza pizza;

        if (type == PizzaTypeEnum.Cheese)
        {
            pizza = new CheesePizza();
        }
        else if (type == PizzaTypeEnum.Pepperoni)
        {
            pizza = new PepperoniPizza();
        }
        else if (type == PizzaTypeEnum.Clam)
        {
            pizza = new ClamPizza();
        }
        else if (type == PizzaTypeEnum.Veggie)
        {
            pizza = new VeggiePizza();
        }
        else
        {
            throw new ArgumentException("Unknown pizza type");
        }

        return pizza;
    }
}
