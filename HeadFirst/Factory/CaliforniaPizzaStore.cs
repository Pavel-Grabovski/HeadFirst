using HeadFirst.Factory.Pizzas;

namespace HeadFirst.Factory;

public class CaliforniaPizzaStore : PizzaStore
{
    public override Pizza CreatePizza(PizzaTypeEnum type)
    {
        Pizza pizza;

        if (type == PizzaTypeEnum.Cheese)
        {
            pizza = new CaliforniaStyleCheesePizza();
        }
        else if (type == PizzaTypeEnum.Pepperoni)
        {
            pizza = new CaliforniaStylePepperoniPizza();
        }
        else if (type == PizzaTypeEnum.Clam)
        {
            pizza = new CaliforniaStyleClamPizza();
        }
        else if (type == PizzaTypeEnum.Veggie)
        {
            pizza = new CaliforniaStyleVeggiePizza();
        }
        else
        {
            throw new ArgumentException("Unknown pizza type");
        }

        return pizza;
    }
}
