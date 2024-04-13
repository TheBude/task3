using System;

class Program
{
    static void Main()
    {
        Console.Write("Matn kiriting: ");
        string input = Console.ReadLine();

        if (IsPalindrome(input))
        {
            Console.WriteLine("Palindrom");
        }
        else
        {
            Console.WriteLine("Palindrom emas");
        }
    }

    static bool IsPalindrome(string text)
    {
        text = text.ToLower();

        string reversed = "";
        for (int i = text.Length - 1; i >= 0; i--)
        {
            reversed += text[i];
        }

        return text == reversed;
    }
}