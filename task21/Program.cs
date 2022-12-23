// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите координату x 1 числа:");
int firstX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y 1 числа:");
int firstY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z 1 числа:");
int firstZ = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату x 2 числа:");
int secondX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y 2 числа:");
int secondY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z 2 числа:");
int secondZ = Convert.ToInt32(Console.ReadLine());

double destination(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    return result;
}

double res = destination(firstX, firstY, firstZ, secondX, secondY, secondZ);
Console.WriteLine($"{Math.Round(res, 2, MidpointRounding.ToZero)}");
