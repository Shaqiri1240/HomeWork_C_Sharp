// Напишите программу которая принимает на вход 
// трехзначное число и на выходде показывает вторую цифру этого числа
Console.WriteLine("Введите трехзначное число");
int Num = Convert.ToInt32(Console.ReadLine());
int SecNum = 0;
if (Num < 100 || Num > 999) Console.WriteLine("Необходимо трёхзначное число");
else SecNum = Num % 100 / 10;
Console.WriteLine($"Вторая цифра числа {Num} = {SecNum}");