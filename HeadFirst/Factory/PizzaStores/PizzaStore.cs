using HeadFirst.Factory.Pizzas;

namespace HeadFirst.Factory.PizzaStores;

public abstract class PizzaStore
{
    public virtual Pizza OrderPizza(PizzaTypeEnum type)
    {
        Pizza pizza;

        pizza = CreatePizza(type);

        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();
        return pizza;
    }

    public abstract Pizza CreatePizza(PizzaTypeEnum type);
}
