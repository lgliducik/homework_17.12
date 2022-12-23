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
    int numb;
    while (temp > 0)
    {
        numb = temp % 10;
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


bool IsPalindromString(int num)
{
    string number_string = Convert.ToString(num);
    char[] arr = number_string.ToCharArray();
    Array.Reverse(arr);
    int number_revert = Convert.ToInt32(new String(arr));
    if (number_revert == num)
    {
        return true;
    }
    else
    {
        return false;
    }
}