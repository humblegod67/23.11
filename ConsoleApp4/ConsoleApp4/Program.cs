using System;

class Program
{
    static void Main()
    {
        // Ввод числа от пользователя
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        // Проверка диапазона
        if (number >= 5 && number <= 10)
        {
            Console.WriteLine($"{number} попадает в диапазон от 5 до 10 включительно.");
        }
        else
        {
            Console.WriteLine($"{number} не попадает в указанный диапазон.");
        }
    }
}
