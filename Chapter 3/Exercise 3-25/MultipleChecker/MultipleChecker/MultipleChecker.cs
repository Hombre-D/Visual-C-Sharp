using System;


class MultipleChecker
{
    static void Main(string[] args)
    {
        int first, second;
        Console.WriteLine("Multiple Checker");
        Console.Write("Enter a number: ");
        first = int.Parse(Console.ReadLine());
        Console.Write("Enter another number: ");
        second = int.Parse(Console.ReadLine());

        if (first % second == 0)
        {
            Console.WriteLine($"{first} is a multiple of {second}");
        }
        else
        {
            Console.WriteLine($"{first} is not a multiple of {second}");
        }
    }
}

