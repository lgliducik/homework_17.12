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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 5},");
            else Console.Write($"{matrix[i, j],5}");
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
    
    for (int matrix1_row = 0; matrix1_row < matrix1Rows; matrix1_row++) 
    {
        // для каждой матрицы 1 строка, цикл по столбцам матрицы 2  
        for (int matrix2_col = 0; matrix2_col < matrix2Cols; matrix2_col++) 
        {
            // цикл по столбцам матрицы 1 для вычисления скалярного произведения  
            for (int matrix1_col = 0; matrix1_col < matrix1Cols; matrix1_col++) 
            {
                multmatrix[matrix1_row, matrix2_col] += firstmatrix[matrix1_row, matrix1_col] * secondmatrix[matrix1_col, matrix2_col];
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