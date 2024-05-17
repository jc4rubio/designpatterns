namespace PizzaStore.AbstractFactory;

internal class ChicagoPizzaStore : PizzaStore
{
    public override Pizza CreatePizza(PizzaStyle style)
    {
        IPizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();

        return style switch
        {
            PizzaStyle.Cheese => new ChicagoStyleCheesePizza(ingredientFactory),
            PizzaStyle.Clam => new ChicagoStyleClamPizza(ingredientFactory),
            PizzaStyle.Pepperony => new ChicagoStylePepperoniPizza(ingredientFactory),
            PizzaStyle.Veggie => new ChicagoStyleVeggiePizza(ingredientFactory),
            _ => throw new ArgumentException("Invalid style", nameof(style))
        };
    }
}
