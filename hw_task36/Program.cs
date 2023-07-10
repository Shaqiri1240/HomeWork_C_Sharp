//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int ArrayOddCount(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0) sum = sum + array[i];

    }
    return sum;
}

void PrintArray(int[] array, string name = "")
{
    Console.WriteLine(name);
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}
int[] array = new int[5];
Random random = new Random();
for (int i = 0; i < 5; i++)
{
    array[i] = random.Next(1, 100);
}
int sum = ArrayOddCount(array);
PrintArray(array);
Console.WriteLine("Сумма нечетных чисел в массиве: " + sum);