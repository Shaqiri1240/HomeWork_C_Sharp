// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int GetNatureDegree(int number,int degree)
{
    int result = number;
    for (int i = 1; i <= degree-1; i++)
    {
        result *= number;
    }
    return result;
}
Console.WriteLine("Введите первое число");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numB = Convert.ToInt32(Console.ReadLine());
int nature = GetNatureDegree(numA,numB);
Console.WriteLine(nature);