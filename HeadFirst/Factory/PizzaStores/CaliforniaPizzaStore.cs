using HeadFirst.Factory.IngredientFactory;
using HeadFirst.Factory.Pizzas;

namespace HeadFirst.Factory.PizzaStores;

public class CaliforniaPizzaStore : PizzaStore
{
    public override Pizza CreatePizza(PizzaTypeEnum type)
    {
        Pizza pizza;
        IPizzaIngredientFactory _ingredientFactory = new CaliforniaPizzaIngredientFactory();

        if (type == PizzaTypeEnum.Cheese)
        {
            pizza = new CaliforniaStyleCheesePizza(_ingredientFactory);
            pizza.SetName("California Style Cheese Pizza");
        }
        else if (type == PizzaTypeEnum.Pepperoni)
        {
            pizza = new CaliforniaStylePepperoniPizza(_ingredientFactory);
            pizza.SetName("California Style Pepperoni Pizza");
        }
        else if (type == PizzaTypeEnum.Clam)
        {
            pizza = new CaliforniaStyleClamPizza(_ingredientFactory);
            pizza.SetName("California Style Clam Pizza");
        }
        else if (type == PizzaTypeEnum.Veggie)
        {
            pizza = new CaliforniaStyleVeggiePizza(_ingredientFactory);
            pizza.SetName("California Style Veggie Pizza");
        }
        else
        {
            throw new ArgumentException("Unknown pizza type");
        }

        return pizza;
    }
}
