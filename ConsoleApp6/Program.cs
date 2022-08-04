while (true)
{
    Console.Write("Введите первое число ");
    int firstnumber = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе  число ");
    int toonumber = Convert.ToInt32(Console.ReadLine());
    if (firstnumber > toonumber)
    {
        Console.WriteLine($"Число {firstnumber}  больше чем {toonumber}");
    }
    else if (firstnumber < toonumber)
    {
        Console.WriteLine($"Число {firstnumber}  меньше чем {toonumber}");
    }
    else if (firstnumber == toonumber)
    {
        Console.WriteLine($"Число {firstnumber}  равно  {toonumber}");
    }
}