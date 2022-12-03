int number = new Random(). Next(100, 1000);
int digit1 = number / 100;
int digit3 = number % 10;
int result = (digit1 * 10) + digit3;
Console.WriteLine($"Случайное число = {number}"); 
Console.WriteLine($"После удаления второй цифры этого числа получается {result}");