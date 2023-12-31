﻿// Задайте двумерный массив. Найдите сумму элементов, находящихся
// на главной диагонали (с индексами 0-0 1-1 и т.д.)

int[,] getRandMatrix(int rows, int columns, int deviation)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            matrix[i, j] = new Random().Next(0, deviation + 1);
    }
    return matrix;
}

void printMatrix(int[,] matrix)
{
    Console.Write("[ ]\t");
    for (int i = 0; i < matrix.GetLength(1); i++)
        Console.Write($"[{i + 1}]" + "\t");

    Console.WriteLine();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write($"[{i + 1}]" + "\t");
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + "\t");
        Console.WriteLine();
    }
}

int SumOfDiagonalElements(int[,] matrix)
{
    int sumOfDiagElements = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
            {
                sumOfDiagElements += matrix[i, j];
            }
        }
    }
    return sumOfDiagElements;
}
int [,] array = getRandMatrix(5,4,10);
printMatrix(array);
Console.WriteLine(SumOfDiagonalElements(array));

