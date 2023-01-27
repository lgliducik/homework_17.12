// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет


int[,] matrix = { { 0, 1, 2 }, { 3, 4, 5 } };

Console.WriteLine("введите i = ");
int inputI = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите j = ");
int inputJ = Convert.ToInt32(Console.ReadLine());

isExistElementIJ(matrix, inputI, inputJ);

void isExistElementIJ(int[,] matrix, int i, int j)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    if (i >= 0 && j >= 0 && i < rows && j < columns)
    {
        Console.WriteLine($"{matrix[i,j]}");
    }
    else Console.WriteLine("Такого элемента нет");
}


