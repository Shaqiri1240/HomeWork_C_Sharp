/* Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());

int Number = 1;

while (Number <= N) {
    if (Number %2 == 0) Console.Write(Number);
    Console.Write(" ");
    Number = Number + 1;
}
