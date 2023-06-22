/* Напишите программу, которая на вход п
ринимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет */

Console.WriteLine("Введите число");
int numA = Convert.ToInt32(Console.ReadLine());
if (numA % 2 == 0) Console.WriteLine("Да");
else Console.WriteLine("Нет");
