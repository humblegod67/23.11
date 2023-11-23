using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int decimalNumber = int.Parse(Console.ReadLine());

        string octalRepresentation = Convert.ToString(decimalNumber, 8);
        int length = octalRepresentation.Length;

        if (length >= 2)
        {
            char secondFromRight = octalRepresentation[length - 2];
            Console.WriteLine($"Вторая цифра справа в восьмеричном представлении: {secondFromRight}");
        }
        else
        {
            Console.WriteLine("Число слишком маленькое для определения второй цифры в восьмеричном представлении.");
        }
    }
}

