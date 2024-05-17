namespace PizzaStore.AbstractFactory;

internal class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
{
    public ICheese CreateCheese() => new ReggianoCheese();

    public IClam CreateClam() => new FreshClams();

    public IDough CreateDough() => new ThikCrustDough();

    public IPepperoni CreatePepperoni() => new SpicyPepperoni();

    public ISauce CreateSauce() => new MarinaraSauce();

    public IEnumerable<IVeggies> CreateVeggies() => [new BlackOlives(), new Spinach(), new Eggplant()];
}
