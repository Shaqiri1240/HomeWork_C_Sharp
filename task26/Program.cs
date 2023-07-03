// Напишите программу, которая принимает на вход 
// число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

System.Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int SumOfNum = 0;
int num1 = num;
if (num == 0)
    SumOfNum = 1;
while (num > 0)
{
    num /= 10;
    SumOfNum++;
}
Console.WriteLine($"В числе {num1},количество цифр = {SumOfNum}");