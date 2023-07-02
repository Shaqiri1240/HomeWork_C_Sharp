//Напишите программу, которая принимает на вход пятизначное
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
start:
Console.WriteLine("Введите пятизначное число");
int Num = Convert.ToInt32(Console.ReadLine());
if ((Num > 99999) || (Num < 9999))
{
    Console.WriteLine("Ошибка,введите пятизначное число.");
    goto start;
}
else {
int num1 = Num / 10000;
int num2 = Num / 1000 % 10;
int num4 = Num % 100 / 10;
int num5 = Num % 10;
if ((num2 == num4) && (num1 == num5))
{
    Console.WriteLine($"Число {Num} является палиндромом.");
}
else 
{
    Console.WriteLine($"Число {Num} не является палиндромом.");
}
}

