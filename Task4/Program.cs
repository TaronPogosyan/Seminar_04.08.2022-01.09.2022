﻿// 7. Напишите программу, которая принимает на вход
// трехзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

// Вариант 1
Console.Write("Напишите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine()); 
int num2 = num % 10;
Console.WriteLine($"Показывает последнюю цифру: {num2}");

// Вариант 2
Console.Write("Введите 3-х значное число: ");
int a = int.Parse(Console.ReadLine());

if (a < 0)
{
    Console.WriteLine($"Крайняя цифра введенного числа: {a * -1 % 10}");
}
else
{
    Console.WriteLine($"Крайняя цифра введенного числа: {a % 10}");
}

 
