using HeadFirst.Factory.Pizzas;

namespace HeadFirst.Factory;

public class NYPizzaStore : PizzaStore
{
    public override Pizza CreatePizza(PizzaTypeEnum type)
    {
        Pizza pizza;

        IPizzaIngredientFactory _ingredientFactory = new NYPizzaIngredientFactory();

        if (type == PizzaTypeEnum.Cheese)
        {
            pizza = new NYStyleCheesePizza(_ingredientFactory);
            pizza.SetName("New York Style Cheese Pizza");
        }
        else if (type == PizzaTypeEnum.Pepperoni)
        {
            pizza = new NYStylePepperoniPizza(_ingredientFactory);
            pizza.SetName("New York Style Pepperoni Pizza");
        }
        else if (type == PizzaTypeEnum.Clam)
        {
            pizza = new NYStyleClamPizza(_ingredientFactory);
            pizza.SetName("New York Style Clam Pizza");
        }
        else if (type == PizzaTypeEnum.Veggie)
        {
            pizza = new NYStyleVeggiePizza(_ingredientFactory);
            pizza.SetName("New York Style Veggie Pizza");
        }
        else
        {
            throw new ArgumentException("Unknown pizza type");
        }

        return pizza;
    }
}
