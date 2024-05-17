namespace PizzaStore.AbstractFactory;

internal class NewYorkStylePepperoniPizza(IPizzaIngredientFactory _pizzaIngredientFactory) : Pizza
{
    private readonly IPizzaIngredientFactory PizzaIngredientFactory = _pizzaIngredientFactory;

    public override void Prepare()
    {
        Console.WriteLine("Preparing " + this.Name);
        this.Dough = PizzaIngredientFactory.CreateDough();
        this.Sauce = PizzaIngredientFactory.CreateSauce();
        this.Pepperoni = PizzaIngredientFactory.CreatePepperoni();
    }
}
