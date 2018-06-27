using System;


class MinimumFinder
{
    static void Main(string[] args)
    {
        float a, b, c;
        Console.WriteLine("Welcome to Minimum Finder!");
        Console.Write("Enter a floating point number: ");
        a = float.Parse(Console.ReadLine());
        Console.Write("Enter a floating point number: ");
        b = float.Parse(Console.ReadLine());
        Console.Write("Enter a floating point number: ");
        c = float.Parse(Console.ReadLine());

        Console.WriteLine($"The smallest value is {Minimum(a, b, c)}");

    }

    static float Minimum (float a, float b, float c)
    {
        return Math.Min(Math.Min(a, b), c);
    }

}

