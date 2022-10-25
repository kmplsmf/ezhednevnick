int position = 4;
int dt = 0;
while(true)
{
    ConsoleKeyInfo key = Console.ReadKey();
    if (key.Key == ConsoleKey.UpArrow)
    {
        Console.Clear();
        position--;
        Console.SetCursorPosition(0, position);
        Console.WriteLine("->");
        zametki();
    }
    else if (key.Key == ConsoleKey.DownArrow)
    {
        Console.Clear();
        position++;
        Console.SetCursorPosition(0, position);
        Console.WriteLine("->");
        zametki();
    }
    else if (key.Key == ConsoleKey.LeftArrow)
    {
        Console.Clear();
        DateTime date = new(2017, 6, 2);
        date = date.AddDays(-dt);
        Console.WriteLine(date);
        dt++;
        zametki();
    }
    else if (key.Key == ConsoleKey.RightArrow)
    {
        Console.Clear();
        DateTime date = new(2017, 6, 2);
        date = date.AddDays(dt);
        Console.WriteLine(date);
        dt++;
        zametki();
    }
    else if (key.Key == ConsoleKey.Z)
    {
        dt = 0;
        Console.Clear();
    }
    else if (key.Key == ConsoleKey.Escape)
    {
        break;
    }
}
static void zametki()
{
    Console.SetCursorPosition(0, 2);
    Console.WriteLine("------------------------------");
    Console.WriteLine("    1. Сходить на пары");
    Console.WriteLine("    2. Поспать дома в тёпленькой кроватке");
    Console.WriteLine("    3. Пойти попить пивка");
}
