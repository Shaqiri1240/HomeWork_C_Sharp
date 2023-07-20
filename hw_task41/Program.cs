// Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int count = 0;
string exit = "break";
bool checkParse = false;
string Permission = "да";
start:
Console.WriteLine("Хотите посчитать числа больше 0? (да/нет)");
Permission = Console.ReadLine();
if (Permission == "да")
{
    while(true)
    {
        Console.WriteLine("Введите число\nДля подсчета введите break");
        string userInput = Console.ReadLine();
        if(userInput.ToString() == "break")
        {
            Console.Clear();

            if(checkParse == true)
                System.Console.WriteLine(count);
            else
                System.Console.WriteLine("Error. UserInput");

            count = 0;
            goto start;
        }
        else
        {
            int number;
            checkParse = Int32.TryParse(userInput, out number);
            if(number > 0)
                count++;
        }
    }
}
else if (Permission == "нет")
{
Console.WriteLine("Подсчет окончен");
}
else 
Console.WriteLine("Нет такого ответа. Я же сказал да/нет");
