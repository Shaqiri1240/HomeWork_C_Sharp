// 44. Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int firstNum = 0;
int secNum = 1;
Console.WriteLine("Введите количество чисел Фибоначчи");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("[ ");
Console.Write($"{firstNum} ");
for (int i = 1; i < N; i++)
{
    int temp = 0;
    if (N==1) Console.Write($"{secNum}, ");
    else 
    {
        temp = firstNum + secNum;
        firstNum = secNum;
        secNum = temp;
        Console.Write($"{temp} ");
    }
}
Console.Write("]");