// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int ArrayNatureCount (int[] arr)
{
int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0) count++;
    }
return count;
}


void PrintArray (int[] array, string name = "")
{
    Console.WriteLine(name);
    Console.Write("[");
    for(int i = 0; i < array.Length; i++ )
    {
        Console.Write(array[i]);
        if (i != array.Length -1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int [] array = new int [5];
Random random = new Random();
for (int i = 0; i < 5; i++)
{
    array[i] = random.Next(99,1000);
}

PrintArray(array);
Console.WriteLine($"Количество четных чисел в массиве - {ArrayNatureCount(array)}");