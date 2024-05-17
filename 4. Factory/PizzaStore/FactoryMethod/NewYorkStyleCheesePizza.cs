namespace PizzaStore.FactoryMethod;

internal class NewYorkStyleCheesePizza : Pizza
{
    public NewYorkStyleCheesePizza()
    {
        base.Name = "NY Style Sauce and Cheese Pizza";
        base.Dough = "Thin Crust Dough";
        base.Sauce = "Marinara Sauce";
        base.Toppings = ["Grated Regiano Cheese"];
    }
}
