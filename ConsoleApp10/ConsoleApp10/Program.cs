using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int originalNumber = int.Parse(Console.ReadLine());
        int modifiedNumber = originalNumber ^ (1 << 1);

        Console.WriteLine($"Число после изменения значения второго бита: {modifiedNumber}");
    }
}