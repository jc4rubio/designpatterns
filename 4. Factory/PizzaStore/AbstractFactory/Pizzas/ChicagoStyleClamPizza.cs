﻿namespace PizzaStore.AbstractFactory;

internal class ChicagoStyleClamPizza(IPizzaIngredientFactory _pizzaIngredientFactory) : Pizza
{
    private readonly IPizzaIngredientFactory PizzaIngredientFactory = _pizzaIngredientFactory;

    public override void Prepare()
    {
        Console.WriteLine("Preparing " + this.Name);
        this.Dough = PizzaIngredientFactory.CreateDough();
        this.Sauce = PizzaIngredientFactory.CreateSauce();
        this.Clam = PizzaIngredientFactory.CreateClam();
    }
}
