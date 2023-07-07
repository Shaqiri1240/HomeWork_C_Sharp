// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int FindLength(int number)
{
    int count = 0;
     for (int i = 0;number > 0;i++)
    {
        number /= 10;
        count++;
    }
    return count;
}
int Sum(int number, int length)
{
    int sum = 0;
    for (int i = 1; i <= length; i++)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}
Console.WriteLine("Введите ваше число.");
int number = Convert.ToInt32(Console.ReadLine());
int length = FindLength(number);
Console.Write($"Сумма цифр в числе {number} равна: {Sum(number,length)}");
