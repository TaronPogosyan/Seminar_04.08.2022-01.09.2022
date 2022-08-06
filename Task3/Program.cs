// 5. Напишите программу, которая на вход принимаетодно число (N),
// а на выходе показывает все целые числа в промежутке от -N до N
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> "-2, -1, 0, 1, 2"

// Вариант 1
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine()); 
int num2 = -num;
while (num2 <= num)
{
    Console.Write(num2 + ", ");
    num2++;
}
Console.WriteLine();

// Вариант 2
Console.Write("Напишите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Вывод чисел в промежутке от -N до N: ");
for (int i = -a; i <= a; i++)
{
    Console.Write(i + " ");
}
