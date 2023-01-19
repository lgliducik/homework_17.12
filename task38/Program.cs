// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2



double[] array = CreateRndDouble(5, 1, 99);
PrintArrayDouble(array);
double maxElem = FindMax(array);
double minElem = FindMin(array);
double diff = maxElem - minElem;

Console.WriteLine($"max = {maxElem}");
Console.WriteLine($"min = {minElem}");

Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {Math.Round(diff, 1)}");

double FindMax(double[] arr)
{
    double max = arr[0];
    for(int i = 0; i<arr.Length; i++)
    {
        if(arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}

double FindMin(double[] arr)
{
    double min = arr[0];
    for(int i = 0; i<arr.Length; i++)
    {
        if(arr[i] < min)
        {
            min = arr[i];
        }
    }
    return min;
}

double[] CreateRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for(int i = 0; i<arr.Length; i++)
    {
        double rndD = rnd.NextDouble();
        double num = rndD*(max-min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

void PrintArrayDouble(double []arr)
{
    for(int i = 0; i<arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}