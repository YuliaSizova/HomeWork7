/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4*/



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

void GetElemetPosit(int[,] matrix)
{
    Console.WriteLine("Введите индекс строки");
    int line = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите индекс столбца");
    int column = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine();
    if ((line <= matrix.GetLength(0)) && (column <= matrix.GetLength(1)))
    {
        System.Console.WriteLine($"элемент-> {matrix[line, column]}");
    }
    else System.Console.WriteLine("Такого элемента нет");
}

int[,] matrix = Generate2DArray(3, 4);
Print2DArray(matrix);
System.Console.WriteLine();
GetElemetPosit(matrix);
