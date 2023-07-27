// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

void MultiplyMatrix(int[,] firstMtr, int[,] secondMtr, int[,] resultMtr)
{
  for (int i = 0; i < resultMtr.GetLength(0); i++)
  {
    for (int j = 0; j < resultMtr.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMtr.GetLength(1); k++)
      {
        sum += firstMtr[i,k] * secondMtr[k,j];
      }
      resultMtr[i,j] = sum;
    }
  }
}

int[,] firstMtr = getRandMatrix(2, 2, 9);
int[,] secondMtr = getRandMatrix(2, 2, 9);
int[,] resultMtr = getRandMatrix(2, 2, 9);

MultiplyMatrix(firstMtr, secondMtr, resultMtr);
printMatrix(firstMtr);
Console.WriteLine("-----------------------");
printMatrix(secondMtr);
Console.WriteLine("Произведение первой и второй матриц:");
printMatrix(resultMtr);
