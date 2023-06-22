/* Напишите программу, которая принимает на вход трёхзначное 
число и на выходе показывает последнюю цифру этого числа.*/

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 || number > 999) Console.WriteLine("Необходимо трёхзначное число!");
else {
int count = number % 10;
Console.Write(count);
}