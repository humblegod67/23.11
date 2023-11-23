using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int decimalNumber = int.Parse(Console.ReadLine());
        int shiftedNumber = decimalNumber >> 2; 
        int thirdBit = shiftedNumber & 1;
        Console.WriteLine($"Третий бит справа в двоичном представлении: {thirdBit}");
    }
}