using StarbuzzCoffe;

Console.WriteLine("Decorator pattern");

Beberage beberage1 = new Caramel(new Espresso());

Console.WriteLine("\nBeberage 1");
Console.WriteLine("Description: " + beberage1.Description());
Console.WriteLine("Total cost: " + beberage1.Cost());

Beberage beberage2 = new Chocolate(new Decaf());

Console.WriteLine("\nBeberage 2");
Console.WriteLine("Description: " + beberage2.Description());
Console.WriteLine("Total cost: " + beberage2.Cost());

Beberage beberage3 = new Caramel(new Chocolate(new Decaf()));

Console.WriteLine("\nBeberage 3");
Console.WriteLine("Description: " + beberage3.Description());
Console.WriteLine("Total cost: " + beberage3.Cost());
