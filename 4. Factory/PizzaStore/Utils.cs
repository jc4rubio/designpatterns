namespace PizzaStore;

using System.Text.RegularExpressions;

internal static class Utils
{

    public static string GetSplitCamelCaseName<T>(T type) where T : class => SplitCamelCase(type.GetType().Name);

    private static string SplitCamelCase(string input)
    {
        string pattern = @"(?<=[a-z])(?=[A-Z])";
        string[] words = Regex.Split(input, pattern);
        return string.Join(" ", words);
    }
}
