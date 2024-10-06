using static System.Console;
using System;
using System.Data;

class Task1
{
    static void Main()
    {
        string input;
        do
        {
            WriteLine("Enter an arithmetic expression: ");
            input = ReadLine().Replace(" ", ""); // Убираем пробелы
            if (IsValidExpression(input))
            {
                try
                {
                    // Использование DataTable для вычисления выражений
                    var result = new DataTable().Compute(input, null);
                    WriteLine($"Result: {result}");
                }
                catch (Exception ex)
                {
                    WriteLine("Error in expression: " + ex.Message);
                }
                break;
            }
            else
            {
                WriteLine("Input error! Only numbers and +, -, *, / signs are allowed. Try again.");
            }
        } while (true);
    }

    // Проверка на допустимые символы
    static bool IsValidExpression(string expression)
    {
        foreach (char c in expression)
        {
            if (!char.IsDigit(c) && c != '+' && c != '-' && c != '*' && c != '/')
            {
                return false;
            }
        }
        return true;
    }
}
