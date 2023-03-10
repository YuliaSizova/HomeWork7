/* Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/ 
Print2DArray(Generate2DArray(3,4));

static double[,] Generate2DArray( int m ,   int n)
{
    double[,] result = new double[m, n];


    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().NextDouble()* new Random().Next(-10,10);
        }
    }
    return result; 
}

void Print2DArray(double[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]:f2} ");
        }
        Console.WriteLine();
    }
}