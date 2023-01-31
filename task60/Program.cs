// *Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)


int[,,] Create3DRndInt(int x1, int x2,int x3, int min, int max)
{
    int[,,] array3D = new int[x1, x2, x3];
    Random rnd = new Random();
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                array3D[i,j, k] = rnd.Next(min, max + 1);
            }
        }
    }
    return array3D;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                Console.Write($"{matrix[i, j, k],5}, ({i}, {j}, {k})");
            }
        }
        Console.WriteLine("]");
    }
}

int[,,] array3 = Create3DRndInt(2, 2,2, 1, 10);
PrintMatrix(array3);