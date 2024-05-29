namespace TemplateMethod;

internal static class Utils
{
    public static string GetUserInput()
    {
        string? input = null;

        try
        {
            input = Console.ReadKey().ToString();
        }
        catch (IOException)
        {
            Console.WriteLine("IO error trying to read your answer");
        }

        return input is null ? "no" : input;
    }
}
