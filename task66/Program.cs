// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите натуральное число M:");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N:");
int numberN = Convert.ToInt32(Console.ReadLine());
if (numberM >= 0 && numberN >= 0)
{
    int sum = SumNatural(numberM, numberN);
    Console.WriteLine($"{sum}");
}
else
{
    Console.WriteLine("Число не натуральное:");
}

int SumNatural(int M, int N)
{
    if (M == N) return M;
    if (M > N)
    {
        int temp = M;
        M = N; 
        N = temp; 
    }
    return M + SumNatural( M + 1, N); 
}
