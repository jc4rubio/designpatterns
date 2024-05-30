using Iterator;

Console.WriteLine("Iterator pattern");
Console.WriteLine("----------------");

MenuTestDrive();

static void MenuTestDrive()
{
    PancakeHouseMenu pancakeHouseMenu = new();
    DinerMenu dinerMenu = new();
    CafeMenu cafeMenu = new();

    Waitress waitress = new(pancakeHouseMenu, dinerMenu, cafeMenu);

    waitress.PrintMenu();
}
