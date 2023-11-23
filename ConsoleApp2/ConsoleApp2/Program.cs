using System;

class Program
{
    static void Main()
    {
        // Ввод числа от пользователя
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        // Проверка критериев
        if (number % 5 == 2 || number % 7 == 1)
        {
            Console.WriteLine($"{number} удовлетворяет хотя бы одному из условий.");
        }
        else
        {
            Console.WriteLine($"{number} не удовлетворяет ни одному из условий.");
        }
    }
}