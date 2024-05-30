namespace Composite;

internal class Waitress(MenuComponent allMenus)
{
    private readonly MenuComponent _allMenus = allMenus;

    public void PrintMenu()
    {
        this._allMenus.Print();
    }
}
