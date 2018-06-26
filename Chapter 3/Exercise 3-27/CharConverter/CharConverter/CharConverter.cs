using System;

class CharConverter
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Char Converter!");
        char input = ' ';
        
        while (input != '*')
        {
            try
            {
                Console.Write("Enter a char value (or * to quit): ");
                input = Char.Parse(Console.ReadLine());
                if (input == '*')
                {
                    Console.WriteLine("Thanks for using Char Converter!");
                    break;
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Enter a single character.");
                continue;
            }
            Console.WriteLine($"The character {input} has the int value {(int)input}.");
        }
    }
}

