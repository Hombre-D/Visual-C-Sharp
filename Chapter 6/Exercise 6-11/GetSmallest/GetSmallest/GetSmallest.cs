using System;

class GetSmallest
{
    static void Main(string[] args)
    {
        int total, value;
        int smallest = int.MaxValue;

        Console.Write("Enter the number of integers to compare: ");
        total = int.Parse(Console.ReadLine());

        for (int i = 0; i < total; ++i)
        {
            Console.Write("\nEnter an integer: ");
            value = int.Parse(Console.ReadLine());
            if (value < smallest){
                smallest = value;
            }

        }

        Console.WriteLine($"Smallest value entered: {smallest}");

    }
}

