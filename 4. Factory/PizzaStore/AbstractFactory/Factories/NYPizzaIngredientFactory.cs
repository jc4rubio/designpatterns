namespace PizzaStore.AbstractFactory;

internal class NYPizzaIngredientFactory : IPizzaIngredientFactory
{
    public ICheese CreateCheese() => new MozarellaCheese();

    public IClam CreateClam() => new FrozenClams();

    public IDough CreateDough() => new ThinCrustDough();

    public IPepperoni CreatePepperoni() => new SlicedPepperoni();

    public ISauce CreateSauce() => new PlumTomatoSauce();

    public IEnumerable<IVeggies> CreateVeggies() => [new Garlic(), new Onion(), new Mushroom(), new RedPepper()];
}
