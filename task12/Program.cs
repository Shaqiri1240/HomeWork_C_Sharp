// # Напишите программу, которая будет принимать на вход два 
// числа и выводить, является ли второе число кратным первому. 
// Если второе число некратно первому, то программа выводит 
// остаток от деления.
// 34, 5 -> некратно, остаток 4
// 16, 4 -> кратно
Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
int newNum = 0;
if (num1 % num2 == 0) Console.WriteLine("Второе число кратно первому");
else 
{newNum = num1 % num2;
Console.WriteLine($"Остаток от деления {newNum}");
}
