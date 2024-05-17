namespace PizzaStore.AbstractFactory;

internal class CaliforniaPizzaStore : PizzaStore
{
    public override Pizza CreatePizza(PizzaStyle style)
    {
        IPizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();

        return style switch
        {
            PizzaStyle.Cheese => new CaliforniaStyleCheesePizza(ingredientFactory),
            PizzaStyle.Clam => new CaliforniaStyleClamPizza(ingredientFactory),
            PizzaStyle.Pepperony => new CaliforniaStylePepperoniPizza(ingredientFactory),
            PizzaStyle.Veggie => new CaliforniaStyleVeggiePizza(ingredientFactory),
            _ => throw new ArgumentException("Invalid style", nameof(style))
        };
    }
}
