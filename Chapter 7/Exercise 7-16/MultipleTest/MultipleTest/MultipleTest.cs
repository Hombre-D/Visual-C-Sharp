using System;


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter an integer: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter another integer: ");
        int b = int.Parse(Console.ReadLine());

        bool isMultiple = Multiple(a, b);

        if (isMultiple)
        {
            Console.WriteLine($"{b} is a multiple of {a}");
        }
        else
        {
            Console.WriteLine($"{b} is not a multiple of {a}");
        }

    }

    static bool Multiple(int a, int b) => (b % a == 0);

}

