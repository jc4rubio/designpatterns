namespace PizzaStore.AbstractFactory;

internal class NewYorkPizzaStore : PizzaStore
{
    public override Pizza CreatePizza(PizzaStyle style)
    {
        IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

        return style switch
        {
            PizzaStyle.Cheese => new NewYorkStyleCheesePizza(ingredientFactory),
            PizzaStyle.Clam => new NewYorkStyleClamPizza(ingredientFactory),
            PizzaStyle.Pepperony => new NewYorkStylePepperoniPizza(ingredientFactory),
            PizzaStyle.Veggie => new NewYorkStyleVeggiePizza(ingredientFactory),
            _ => throw new ArgumentException("Invalid style", nameof(style))
        };
    }
}
