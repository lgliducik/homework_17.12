// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 5},");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine("]");
    }
}

int[] SortedRowsInMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int[,] newmatrix = new int[rows, columns];
    int[] arrayrow = new int[columns];
    int[] sumrowindex = new int[rows];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arrayrow[j] = matrix[i,j]; 
        } 
        int sum = 0;
        for (int j = 0; j < columns; j++)
        {
            sum += arrayrow[j]; 
        }
        Console.WriteLine($"sum = {sum}, index = {i} "); 
        sumrowindex[i] = sum;  
    }
    return sumrowindex;
}

int[] FindMin(int[] arr)
{
    int min = arr[0];
    int index = -1;
    for(int i = 0; i<arr.Length; i++)
    {
        if (arr[i]<min) 
        {
            min = arr[i];
            index = i;
        }
    }
    return new int[2]{min, index};
}


int[,] array2D = CreateMatrixRndInt(4,4, 1,10);
PrintMatrix(array2D);

int[] arr = SortedRowsInMatrix(array2D);

int[] findMin = FindMin(arr);
Console.WriteLine($"min = {findMin[0]}, {findMin[1]} строка"); 
