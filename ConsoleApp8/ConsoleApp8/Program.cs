class Program
{
    static void Main()
    {
        Console.Write("Введите число в бинарном представлении (без '0b'): "); string num1 = Console.ReadLine();
        if (IsBinaryString(num1))
        { 
            int num2 = Convert.ToInt32(num1, 2);

            Console.WriteLine($"Результат после установки третьего бита в единицу: {Convert.ToString(num2, 2)}"); Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Введенное значение не является корректным бинарным числом."); Console.ReadLine();
        }
    }
    static bool IsBinaryString(string input)
    {
        foreach (char c in input)
        {
            if (c != '0' && c != '1')
            {
                return false;
            }
        }
        return true;
    }
}