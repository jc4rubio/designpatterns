namespace TemplateMethod;

internal class CoffeeWithHook : CaffeineBeverageWithHook
{
    protected override void AddCondiments() => Console.WriteLine("Adding Sugar and Milk");

    protected override void Brew() => Console.WriteLine("Dripping Coffee through filter");

    protected override bool CustomerWantsCondiments()
    {
        Console.WriteLine("Would you like milk and sugar with your coffee (y/n)? ");

        string answer = Utils.GetUserInput();

        return answer.ToLower().StartsWith('y');
    }
}
