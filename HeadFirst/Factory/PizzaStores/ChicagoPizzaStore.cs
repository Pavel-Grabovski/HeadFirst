using HeadFirst.Factory.IngredientFactory;
using HeadFirst.Factory.Pizzas;

namespace HeadFirst.Factory.PizzaStores;

public class ChicagoPizzaStore : PizzaStore
{
    public override Pizza CreatePizza(PizzaTypeEnum type)
    {
        Pizza pizza;
        IPizzaIngredientFactory _ingredientFactory = new ChicagoPizzaIngredientFactory();

        if (type == PizzaTypeEnum.Cheese)
        {
            pizza = new ChicagoStyleCheesePizza(_ingredientFactory);
            pizza.SetName("Chicago Style Cheese Pizza");
        }
        else if (type == PizzaTypeEnum.Pepperoni)
        {
            pizza = new ChicagoStylePepperoniPizza(_ingredientFactory);
            pizza.SetName("Chicago Style Pepperoni Pizza");
        }
        else if (type == PizzaTypeEnum.Clam)
        {
            pizza = new ChicagoStyleClamPizza(_ingredientFactory);
            pizza.SetName("Chicago Style Clam Pizza");

        }
        else if (type == PizzaTypeEnum.Veggie)
        {
            pizza = new ChicagoStyleVeggiePizza(_ingredientFactory);
            pizza.SetName("Chicago Style Veggie Pizza");
        }
        else
        {
            throw new ArgumentException("Unknown pizza type");
        }

        return pizza;
    }
}
