// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие
//  отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int [] getRandomArray(int length, int deviation)
{
    int [] result = new int [length];
    for(int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(-deviation, deviation + 1);
    }
    return result;
}

void printArray (int[] arrayToPrint)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("[");
    for(int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i != arrayToPrint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
    Console.ForegroundColor = ConsoleColor.White;
}

int [] randomArray = getRandomArray(4, 9);
printArray(randomArray);

for(int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] *= -1;
}

printArray(randomArray);
