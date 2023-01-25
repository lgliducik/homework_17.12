// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("k1 = ");
double inputK1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("k2 = ");
double inputK2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("b1 = ");
double inputB1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("b2 = ");
double inputB2 = Convert.ToInt32(Console.ReadLine());

double[] FindCrossPoint(double k1, double k2, double b1, double b2)
{
    double[] res = new double[2];
    if(k1 != k2 || b1 != b2)
    {
        res[0] = Math.Round((b2-b1)/(k1-k2), 1);
        res[1] = Math.Round(k2* res[0] + b2, 1);
    }
    return res;
}

double[] res = FindCrossPoint(inputK1, inputK2, inputB1, inputB2);
Console.Write($"({res[0]}, {res[1]})");
