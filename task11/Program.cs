// Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа.

int randomNumber = new Random().Next(100, 1000);
Console.Write($"Случайное число - {randomNumber} без второй цифры ");
int numberOne = randomNumber / 100;
int numberTwo = randomNumber % 10;
int newNumber = numberOne * 10 + numberTwo;
Console.WriteLine(newNumber);
