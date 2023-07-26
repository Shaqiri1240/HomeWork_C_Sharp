// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
start:
Console.WriteLine("Введите натуральное число от 1 до 9");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 9) 
{
    Console.WriteLine("Ошибка - введите натуральное число!");
    goto start;
}
int length = num;
void FindNature(int number)
{
    if (length > 0)
    {
        Console.Write($"{num} ");
        length -= 1;
        num -= 1;
        FindNature(num);
    } 
}
FindNature(num);