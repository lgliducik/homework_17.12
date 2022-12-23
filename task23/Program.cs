// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125


Console.WriteLine("Введите натуральное число N:");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 0)
{
    TableCube(n);
}
else
{
    Console.WriteLine("число не натуральное");
}

void TableCube(int number)
{
    int count = 1;
    while (count <= number)
    {
        Console.WriteLine($"{count} | {Math.Pow(count, 3)}");
        count++;
    }
}
