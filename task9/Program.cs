﻿int number = new Random().Next(10, 100);
int digit2 = number % 10;
int digit1 = number / 10;
Console.WriteLine($"Случайное число = {number}, первая цифра = {digit1}, вторая цифра = {digit2}");
int max = digit1;
if (max < digit2)
{
    max = digit2;
}
Console.WriteLine(max);