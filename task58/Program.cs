// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine("]");
    }
}

int[,] MultMatrix(int[,] firstmatrix, int[,] secondmatrix)
{
    var matrix1Rows = firstmatrix.GetLength(0);
    var matrix1Cols = firstmatrix.GetLength(1);
    var matrix2Rows = secondmatrix.GetLength(0);
    var matrix2Cols = secondmatrix.GetLength(1);
    int[,] multmatrix = new int[matrix1Rows, matrix2Cols];
    
    for (int row = 0; row < matrix1Rows; row++) 
    { 
        for (int col = 0; col < matrix2Cols; col++) 
        { 
            for (int runner = 0; runner < matrix1Cols; runner++) 
            {
                multmatrix[row, col] += firstmatrix[row, runner] * secondmatrix[runner, col];
            }  
        }  
    }  
    return multmatrix;
}

int[,] firstarray = CreateMatrixRndInt(2,2, 1,10);
PrintMatrix(firstarray);
Console.WriteLine(" ");
int[,] secondarray = CreateMatrixRndInt(2,2, 1,10);
PrintMatrix(secondarray);
Console.WriteLine(" ");

int[,] multmatrix = MultMatrix(firstarray, secondarray);
PrintMatrix(multmatrix);