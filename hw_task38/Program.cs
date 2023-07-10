double MinMaxDiff (double [] array)
{
    double diff = 0;
    double min = array[0];
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        else if (array[i] > max) max = array[i];
    }
diff = max - min;
return diff;
}
void PrintArray(double[] array, string name = "")
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
double[] array = new double[5];
Random random = new Random();
for (int i = 0; i < 5; i++)
{
    array[i] = Math.Round(random.NextDouble() * 100, 2);
}
double diff = MinMaxDiff(array);
PrintArray(array);
Console.WriteLine("Разница между максимальным и минимальным числами в массиве: " + diff);