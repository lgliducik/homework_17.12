// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


int[] array = CreateRndInt(4, -99, 99);
int res = SumNotEvenNumber(array);

PrintArray(array);
Console.WriteLine($"\nCумма элементов, стоящих на нечётных позициях = {res}");

int[] CreateRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for(int i = 0; i<arr.Length; i++)
    {
        arr[i] = rnd.Next(min,max + 1);
    }
    return arr;
}

void PrintArray(int []arr)
{
    Console.Write("[");
    foreach (int element in arr)
    {
        Console.Write(element + " ");
    }
    Console.Write("]");
}

int SumNotEvenNumber(int[] arr)
{
    int count = 0;
    for(int i = 0; i<arr.Length; i++)
    {
        if (i%2 != 0)
        {
            count+=arr[i];
        }
    }
    return count;
}
