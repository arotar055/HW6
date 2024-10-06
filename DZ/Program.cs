using static System.Console;
using System;

class Task2
{
    static void Main()
    {
        try
        {
            string input;
            do
            {
                WriteLine("Enter a sentence or text:");
                input = ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                    WriteLine("Please, enter some text.");
            } while (string.IsNullOrWhiteSpace(input));

            FormatText(input);
        }
        catch (Exception ex)
        {
            WriteLine("Error: " + ex.Message);
        }
    }

    // Функция для форматирования текста
    static void FormatText(string text)
    {
        string[] sentences = text.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string sentence in sentences)
        {
            string trimmedSentence = sentence.Trim();
            if (trimmedSentence.Length > 0)
            {
                Write(char.ToUpper(trimmedSentence[0]) + trimmedSentence.Substring(1) + ". ");
            }
        }
        WriteLine();
    }
}
