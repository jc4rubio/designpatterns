namespace PizzaStore.AbstractFactory;

internal abstract class PizzaStore
{
    public abstract Pizza CreatePizza(PizzaStyle style);
}
