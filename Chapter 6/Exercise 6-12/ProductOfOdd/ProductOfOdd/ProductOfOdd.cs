using System;


    class ProductOfOdd
{
    static void Main(string[] args)
    {
        int total = 1;

        for (int i = 1; i <= 7; ++i)
        {
            if (i % 2 != 0)
            {
                total *= i;
            }
        }

        Console.WriteLine($"Product of odd numbers 1-7: {total}");

    }
}

