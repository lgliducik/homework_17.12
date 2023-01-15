// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


Console.WriteLine("Введите размерность массива:");
int size_arr = Convert.ToInt32(Console.ReadLine());

int[] array = CreateMass(size_arr);

PrintMass(array);

int[] CreateMass(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for(int i = 0; i<array.Length; i++)
    {
        array[i] = rnd.Next(0,100);
    }
    return array;
}

void PrintMass(int[] arr)
{
    for(int i = 0; i<arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        Console.Write(", ");
    }
    Console.Write("->[");
    for(int i = 0; i<arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write("]");
}