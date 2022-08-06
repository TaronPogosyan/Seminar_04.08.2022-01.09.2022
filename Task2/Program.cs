// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница


Console.Write("Введите дни недели: ");
int num1 = Convert.ToInt32(Console.ReadLine()); 
if(num1 == 1) 
{
    Console.Write($"Понедельник, это число {num1}");
}
else if (num1 == 2) 
{
    Console.Write($"Вторник, это число {num1}");
}
else if (num1 == 3) 
{
    Console.Write($"Вторник, это число {num1}");
}
else if (num1 == 4) 
{
    Console.Write($"Среда, это число {num1}");
}
else if (num1 == 5) 
{
    Console.Write($"Четверг, это число {num1}");
}
else if (num1 == 6) 
{
    Console.Write($"Суббота, это число {num1}");
}
else if (num1 == 7) 
{
    Console.Write($"Восскресение, это число {num1}");
}
else 
{
    Console.Write($"Число не дни недели {num1}");
}