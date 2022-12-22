// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int FindThird(int num)
{
    int c = num;
    while (c > 999)
    {
        c = c / 10;
    }
    return c % 10;
}

if (number < 100)
{
    Console.WriteLine("Цифра не 3х значная");
}
else
{
    int third = FindThird(number);
    Console.WriteLine($"3-яя цифра: {third}");
}
