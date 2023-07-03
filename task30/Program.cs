// 30. # Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
void fillRandomArray(int[] array)
{
    Random rnd = new Random();
    for(int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(0, 2);
}

void printArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

int[] randomArray = new int[8];
fillRandomArray(randomArray);
printArray(randomArray);