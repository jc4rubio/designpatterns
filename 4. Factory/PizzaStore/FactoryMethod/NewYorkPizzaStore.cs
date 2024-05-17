namespace PizzaStore.FactoryMethod;

internal class NewYorkPizzaStore : PizzaStore
{
    public override Pizza CreatePizza() => new NewYorkStyleCheesePizza();
}
