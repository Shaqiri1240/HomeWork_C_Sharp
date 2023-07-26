// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
start:
Console.WriteLine("Введите меньшее число (M)");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите большее число (N)");
int N = Convert.ToInt32(Console.ReadLine());
if (N<M)
{
    Console.WriteLine("Ошибка - Число M должно быть меньше числа N. Повторите снова.");
    goto start;
}

int length = M;
int sum = M;
int FindSum(int M,int N)
{
    if (length < N)
    {
        length += 1;
        M += 1;
        sum = sum + M;
        FindSum(M,N);
    } 
    return sum;
}
int finish = FindSum(M,N);
Console.WriteLine(finish);