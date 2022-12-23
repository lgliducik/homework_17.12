// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9999 && number < 100000)
{
    if (IsPalindrom(number) == true)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}
else
{
    Console.WriteLine("Вы ввели не пятизначное число");
}

bool IsPalindrom(int num)
{
    int temp = num;
    int result = 0;
    int i = 10000;
    while (temp > 0)
    {
        int numb = temp % 10;
        result = result + numb * i;
        temp = temp / 10;
        i /= 10;
    }
    if (num == result)
    {
        return true;
    }
    else
    {
        return false;
    }
}
