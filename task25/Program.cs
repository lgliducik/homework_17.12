// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степеь числа:");
int degree = Convert.ToInt32(Console.ReadLine());

if (degree>0)
{
    int getDegree = GetDegree(degree);

    Console.WriteLine($"{number} в степени {degree} = {getDegree}");
}
else
{
    Console.WriteLine("Степень должна быть натуральным числом");
}


int GetDegree(int deg)
{
    int rez = 1;
    for(int i = 0; i<deg;i++)
    {
        rez *= number; 
    }
    return rez;
}
