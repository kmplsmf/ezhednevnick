int position = 4;
int dt = 0;
int dt1 = 0;
DateTime date = new(2017, 6, 2);
while (true)
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
        date = new(2017, 6, 2);
        date = date.AddDays(-dt1);
        Console.WriteLine(date);
        dt1++;
        zametki();
    }
    else if (key.Key == ConsoleKey.RightArrow)
    {
        Console.Clear();
        date = new(2017, 6, 2);
        date = date.AddDays(dt);
        Console.WriteLine(date);
        dt++;
        zametki();
    }
    else if (key.Key == ConsoleKey.Z)
    {
        dt1 = 0;
        dt = 0;
        Console.Clear();
    }
    else if (key.Key == ConsoleKey.Escape)
    {
        break;
    }
    else if (key.Key == ConsoleKey.Enter)
    {
        if (position == 3)
        {
            Console.Clear();
            Console.WriteLine(date);
            Console.WriteLine("---------------------------");
            variant1();
        }
        else if (position == 4)
        {
            Console.Clear();
            Console.WriteLine(date);
            Console.WriteLine("---------------------------");
            variant2();
        }
        else if (position == 5)
        {
            Console.Clear();
            Console.WriteLine(date);
            Console.WriteLine("---------------------------");
            variant3();
        }
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
static void variant1()
{
    Console.WriteLine("вы сходили на пары");
    Console.WriteLine("интелект +5");
    Console.WriteLine("усталость +1");
}
static void variant2()
{
    Console.WriteLine("вы поспали дома в тёпленькой кроватке");
    Console.WriteLine("интелект -2");
    Console.WriteLine("усталость -5");
}
static void variant3()
{
    Console.WriteLine("вы попили пивка");
    Console.WriteLine("увы тут без циферок, но я могу сказать что ты становишься быдлом и скоро станешь слушать русский подъездный рэп");
}
