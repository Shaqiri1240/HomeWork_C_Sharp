// Напишите программу которая сообщает третью цифру 
// заданного числа или сообщает что третьей цифры нет.

Console.WriteLine("Введите число");
int Num = Convert.ToInt32(Console.ReadLine());
if  (Num < 100) Console.WriteLine("Третьей цифры нет"); 
else { Console.WriteLine("Окей, сейчас");
while (Num > 999) 
{
    Num = Num / 10;
}
Console.WriteLine($"Третья цифра вашего числа - {Num % 10}"); }