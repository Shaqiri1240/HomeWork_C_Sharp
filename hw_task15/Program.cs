// Напишите программу которая обозначает на вход цифру обозначающую
// день недели и проверяет является ли этот день выходным
start:
Console.WriteLine("Введите цифру от 1 до 7,обозначающее день недели");
int Num = Convert.ToInt32(Console.ReadLine());
if ((Num > 7)||(Num == 0)) {
    Console.WriteLine("Ошибка,введите число от 1 до 7.");
    goto start; }
else    {
    if (Num > 6) Console.WriteLine("Это выходной день.");
    else Console.WriteLine("Это будний день.");
    }