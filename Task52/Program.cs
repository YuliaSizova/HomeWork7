/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/


int[,] Generate2DArray(int m, int n)
{
    int[,] result = new int[m, n];


    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(1, 100);
        }
    }
    return result;
}

void Print2DArray(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}


void GetAveregeColumn(int[,] matrix)
{
    System.Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double average = 0;
        int count = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            average = average + matrix[i, j];
            count++;
        }

        System.Console.Write($"{average / count:f2}, ");
    }

}





int[,] matrix = Generate2DArray(3, 4);
Print2DArray(matrix);
System.Console.WriteLine();
GetAveregeColumn(matrix);


