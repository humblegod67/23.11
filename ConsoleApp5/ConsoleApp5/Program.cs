using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        int fourthDigit = (number / 1000) % 10;

        Console.WriteLine($"Четвертая цифра справа: {fourthDigit}");
    }
}
