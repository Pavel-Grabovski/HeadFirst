using HeadFirst.Factory.Pizzas;

namespace HeadFirst.Factory;

public class NYPizzaStore : PizzaStore
{
    public override Pizza CreatePizza(PizzaTypeEnum type)
    {
        Pizza pizza;

        if (type == PizzaTypeEnum.Cheese)
        {
            pizza = new NYStyleCheesePizza();
        }
        else if (type == PizzaTypeEnum.Pepperoni)
        {
            pizza = new NYStylePepperoniPizza();
        }
        else if (type == PizzaTypeEnum.Clam)
        {
            pizza = new NYStyleClamPizza();
        }
        else if (type == PizzaTypeEnum.Veggie)
        {
            pizza = new NYStyleVeggiePizza();
        }
        else
        {
            throw new ArgumentException("Unknown pizza type");
        }

        return pizza;
    }
}
