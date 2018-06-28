using System;


class Sales
{
    static void Main(string[] args)
    {
        var ranges = new int[11];
        int sales = 0;

        Console.WriteLine("Welcome to Sales Calculator!");

        while (sales != -1)
        {
            Console.Write("Enter monthly sales (or -1 to quit): ");
            sales = int.Parse(Console.ReadLine());
            if (sales == -1)
            {
                
            }
            else
            {
                try
                {
                    ++ranges[SalesCalc(sales) / 100];
                }

                catch (IndexOutOfRangeException e)
                {
                    ++ranges[10];
                }
            }
        }
        DisplaySales(ranges);

    }

    static int SalesCalc(int sales) => 200 + (int)(sales * .09m);

    static void DisplaySales(int [] ranges)
    {
        Console.WriteLine($"{"Range",-6}{"Number", 20}");
        for (int i = 2; i < ranges.Length; ++i)
        {
            Console.WriteLine($"${i * 100,4}-{i * 100 + 99, -6}{ranges[i], 10}");
        }

    } 
}

