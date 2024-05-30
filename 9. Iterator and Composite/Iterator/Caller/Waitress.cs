namespace Iterator;

internal class Waitress(IMenu menu1, IMenu menu2, IMenu menu3)
{
    private readonly IMenu _pancakeHouseMenu = menu1;
    private readonly IMenu _dinerMenu = menu2;
    private readonly IMenu _cafeMenu = menu3;

    public void PrintMenu()
    {
        IEnumerator<MenuItem> pancakeIterator = this._pancakeHouseMenu.CreateIterator();
        IEnumerator<MenuItem> dinerIterator = this._dinerMenu.CreateIterator();
        IEnumerator<MenuItem> cafeIterator = this._cafeMenu.CreateIterator();

        Console.WriteLine("MENU\n----\nBREAKFAST");
        PrintMenu(pancakeIterator);

        Console.WriteLine("\nLUNCH");
        PrintMenu(dinerIterator);

        Console.WriteLine("\nDINNER");
        PrintMenu(cafeIterator);
    }

    private static void PrintMenu(IEnumerator<MenuItem> iterator)
    {
        while (iterator.MoveNext())
        {
            MenuItem menuItem = iterator.Current;
            Console.Write(menuItem.Name + ", ");
            Console.Write(menuItem.Price + " -- ");
            Console.WriteLine(menuItem.Description);
        }
    }
}
