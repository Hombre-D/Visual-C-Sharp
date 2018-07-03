using System;


class PerfectNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Perfect Number Finder!");
        Console.Write("Enter a maximum value: ");
        int maxValue = int.Parse(Console.ReadLine());
        for(int i = 2; i <= maxValue; ++i)
        {
            Perfect(i);
        }
    }

    static void Perfect(int value)
    {
        int total = 1;
        string factors = "1 ";
        if (value % 2 != 0)
        {
            
        }
        else
        {
            for (int i = 2; i <= value / 2; i++)
            {
                if (value % i == 0)
                {
                    total += i;
                    factors = factors + i + " ";
                }
            }

            if (total == value)
            {
                Console.WriteLine($"{value} is perfect!");
                Console.WriteLine($"Factors: {factors}");
            }


        }

    }

}

