Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
if ( a / 100 > 0 )
{
    Console.WriteLine((a - (a / 100) * 100) / 10);

}
else
{
    Console.WriteLine("Число не подходит");
}