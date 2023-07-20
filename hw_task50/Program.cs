// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] getMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        matrix[i, j] = i + j;
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

bool FindPosition(int[,] matrix, int row, int column)
{
    if (row >= matrix.GetLength(0) || column >= matrix.GetLength(1) || row < 0 || column < 0) 
    {
        return false;
    }
    return true;
}

int [,] mtr = getMatrix(3, 4);

Console.WriteLine("Введите строку числа в массиве");
int row = Convert.ToInt32(Console.ReadLine());
row = row - 1;
Console.WriteLine("Введите столбец числа в массиве");
int column = Convert.ToInt32(Console.ReadLine());
column = column - 1;

if(FindPosition(mtr, row, column))
    Console.WriteLine($"Ваше число {mtr[row, column]}");
else
    Console.WriteLine("Введенных данных нет в матрице.");
