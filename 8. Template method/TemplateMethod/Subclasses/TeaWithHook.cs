namespace TemplateMethod;

internal class TeaWithHook : CaffeineBeverageWithHook
{
    protected override void AddCondiments() => Console.WriteLine("Adding Lemon");

    protected override void Brew() => Console.WriteLine("Steeping the tea");

    protected override bool CustomerWantsCondiments()
    {
        Console.WriteLine("Would you like lemon with your tea (y/n)? ");

        string answer = Utils.GetUserInput();

        return answer.ToLower().StartsWith('y');
    }
}
