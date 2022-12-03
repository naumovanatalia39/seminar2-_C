Console.WriteLine("Введите цифру");
int a = Convert.ToInt32(Console.ReadLine());
if (a == 6 || a == 7)
{
    Console.WriteLine("да");
}
else
{
    if (a > 0 && a < 8)
    {
        Console.WriteLine("Нет");
    }
    else
    {
        Console.WriteLine("Цифра не соответствует дню недели");
    }
}