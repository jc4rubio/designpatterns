namespace PizzaStore.AbstractFactory;

internal class CaliforniaPizzaIngredientFactory : IPizzaIngredientFactory
{
    public ICheese CreateCheese() => new ReggianoCheese();

    public IClam CreateClam() => new FrozenClams();

    public IDough CreateDough() => new ThikCrustDough();

    public IPepperoni CreatePepperoni() => new SpicyPepperoni();

    public ISauce CreateSauce() => new PlumTomatoSauce();

    public IEnumerable<IVeggies> CreateVeggies() => [new BlackOlives(), new Spinach()];
}
