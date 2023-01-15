// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int sumNumber = SumNumber(number);

Console.WriteLine($"{number} -> {sumNumber}");

int SumNumber(int num)
{
    int rez = 0;
    while (num>0)
    {
        int temp = num%10;
        num = num/10;
        rez += temp;
    }
    return rez;
}