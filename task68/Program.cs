// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите неотрицательное число m:");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите неотрицательное число n:");
int numberN = Convert.ToInt32(Console.ReadLine());
if (numberM >= 0 && numberN >= 0)
{
    int akkerman = AkkermanFunction(numberM, numberN);
    Console.WriteLine($"{akkerman}");
}
else
{
    Console.WriteLine("Число отрицательное:");
}

static int AkkermanFunction(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return AkkermanFunction(n - 1, 1);
    if (n > 0 && m > 0) return AkkermanFunction(n - 1, AkkermanFunction(n, m - 1));
    return AkkermanFunction(n,m);
}