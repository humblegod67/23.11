using System;

class Program
{
    static void Main()
    {
        // Ввод числа от пользователя
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        // Проверка деления на 3
        if (number % 3 == 0)
        {
            Console.WriteLine($"{number} делится на 3.");
        }
        else
        {
            Console.WriteLine($"{number} не делится на 3.");
        }
    }
}