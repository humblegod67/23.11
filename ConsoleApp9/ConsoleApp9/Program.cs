
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int originalNumber = int.Parse(Console.ReadLine());

        int modifiedNumber = originalNumber & ~(1 << 3);

        Console.WriteLine($"Число после установки четвертого бита в ноль: {modifiedNumber}");
    }
}