using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());
        if (number % 4 == 0 && number >= 10)
        {
            Console.WriteLine($"{number} удовлетворяет условиям.");
        }
        else
        {
            Console.WriteLine($"{number} не удовлетворяет условиям.");
        }
    }
}