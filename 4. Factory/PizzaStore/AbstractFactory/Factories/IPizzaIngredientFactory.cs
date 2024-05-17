namespace PizzaStore.AbstractFactory;

internal interface IPizzaIngredientFactory
{
    IDough CreateDough();

    ISauce CreateSauce();

    ICheese CreateCheese();

    IPepperoni CreatePepperoni();

    IClam CreateClam();

    IEnumerable<IVeggies> CreateVeggies();
}
