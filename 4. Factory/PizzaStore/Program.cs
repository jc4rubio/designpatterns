using PizzaStore.AbstractFactory;

Console.WriteLine("Factory Method");
Console.WriteLine("==============");

PizzaStore.FactoryMethod.NewYorkPizzaStore store = new();

PizzaStore.FactoryMethod.Pizza pizza = store.CreatePizza();

Console.WriteLine(pizza);

Console.WriteLine("\n\n");
Console.WriteLine("Abstract Factory");
Console.WriteLine("================");
Console.WriteLine("\n");

NewYorkPizzaStore newYorkStore = new();

Pizza newYorkCheesePizza = newYorkStore.CreatePizza(PizzaStyle.Cheese);
ProcessPizza(newYorkCheesePizza);

Pizza newYorkClamPizza = newYorkStore.CreatePizza(PizzaStyle.Clam);
ProcessPizza(newYorkClamPizza);

Pizza newYorkPepperoniPizza = newYorkStore.CreatePizza(PizzaStyle.Pepperony);
ProcessPizza(newYorkPepperoniPizza);

Pizza newYorkVeggiePizza = newYorkStore.CreatePizza(PizzaStyle.Veggie);
ProcessPizza(newYorkVeggiePizza);

ChicagoPizzaStore chicagoStore = new();

Pizza chicagoCheesePizza = chicagoStore.CreatePizza(PizzaStyle.Cheese);
ProcessPizza(chicagoCheesePizza);

Pizza chicagoClamPizza = chicagoStore.CreatePizza(PizzaStyle.Clam);
ProcessPizza(chicagoClamPizza);

Pizza chicagoPepperoniPizza = chicagoStore.CreatePizza(PizzaStyle.Pepperony);
ProcessPizza(chicagoPepperoniPizza);

Pizza chicagoVeggiePizza = chicagoStore.CreatePizza(PizzaStyle.Veggie);
ProcessPizza(chicagoVeggiePizza);

CaliforniaPizzaStore californiaStore = new();

Pizza californiaCheesePizza = californiaStore.CreatePizza(PizzaStyle.Cheese);
ProcessPizza(californiaCheesePizza);

Pizza californiaClamPizza = californiaStore.CreatePizza(PizzaStyle.Clam);
ProcessPizza(californiaClamPizza);

Pizza californiaPepperoniPizza = californiaStore.CreatePizza(PizzaStyle.Pepperony);
ProcessPizza(californiaPepperoniPizza);

Pizza californiaVeggiePizza = californiaStore.CreatePizza(PizzaStyle.Veggie);
ProcessPizza(californiaVeggiePizza);

static void ProcessPizza(Pizza pizza)
{
    pizza.Prepare();
    pizza.Bake();
    pizza.Cut();
    pizza.Box();

    Console.WriteLine("Pizza: \n" + pizza);
}

