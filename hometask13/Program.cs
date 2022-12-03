Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
if (a / 100 > 0)
{
    while (a / 1000 > 0)
    {
        a = a / 10;
    }
    Console.WriteLine(a % 10);
}
else
{
    Console.WriteLine("Нет третьего числа");
}