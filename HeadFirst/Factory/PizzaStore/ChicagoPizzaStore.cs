using HeadFirst.Factory.Pizzas;

namespace HeadFirst.Factory.PizzaStore;

public class ChicagoPizzaStore : PizzaStore
{
    public override Pizza CreatePizza(PizzaTypeEnum type)
    {
        Pizza pizza;

        if (type == PizzaTypeEnum.Cheese)
        {
            pizza = new ChicagoStyleCheesePizza();
        }
        else if (type == PizzaTypeEnum.Pepperoni)
        {
            pizza = new ChicagoStylePepperoniPizza();
        }
        else if (type == PizzaTypeEnum.Clam)
        {
            pizza = new ChicagoStyleClamPizza();
        }
        else if (type == PizzaTypeEnum.Veggie)
        {
            pizza = new ChicagoStyleVeggiePizza();
        }
        else
        {
            throw new ArgumentException("Unknown pizza type");
        }

        return pizza;
    }
}
