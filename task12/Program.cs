Console.WriteLine("Введите первое число");
int a = Convert. ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
int res = a % b;
// if (res > 0 || res < 0)
// {
//     Console.WriteLine($"Не кратно, остаток {res}");
// }
// else
// {
//     Console.WriteLine("Кратно");
// }
if (res == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine($"Не кратно, остаток {res}");
}