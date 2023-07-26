// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите число (m)");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число (n)");
int n = Convert.ToInt32(Console.ReadLine());
int findAkkerman(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return findAkkerman(m - 1, 1);
  else return findAkkerman(m - 1, findAkkerman(m, n - 1));
}
int Akkerman = findAkkerman(m, n);
Console.Write($"Функция Аккермана = {Akkerman} ");