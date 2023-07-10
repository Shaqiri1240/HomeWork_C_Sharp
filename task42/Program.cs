// 42. Напишите программу, 
// которая будет преобразовывать десятичное число в двоичное.

double DecimalToBinary(int dec)
{
    double bin = 0;
    int count = 0;
    while (dec > 0)
    {
        bin += dec % 2 * Math.Pow(10, count);
        dec /= 2;
        count++;
    }
    return bin;
}

System.Console.WriteLine(DecimalToBinary(12512));
