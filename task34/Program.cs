// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// По задаче 34 решение рабочее. Неправильно задан диапазон для массив, нужны трёхзначные числа.


int[] array = CreateRndInt(3, 0, 999);
int res = FindEvenNumber(array);

PrintArray(array);
Console.WriteLine($"\nКоличество четных чисел в массиве = {res}");


void PrintArray(int []arr)
{
    Console.Write("[");
    foreach (int element in arr)
    {
        Console.Write(element + " ");
    }
    Console.Write("]");
}

int FindEvenNumber(int[] arr)
{
    int count = 0;
    for(int i = 0; i<arr.Length; i++)
    {
        if (arr[i]%2 == 0)
        {
            count+=1;
        }
    }
    return count;
}

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
