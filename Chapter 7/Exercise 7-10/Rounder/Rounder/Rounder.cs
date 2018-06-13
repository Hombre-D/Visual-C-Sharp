using System;


class Rounder
{
    static void Main(string[] args)
    {
        double number;
        Console.WriteLine("Welcome to Rounder!");
        Console.Write("Enter a double value (or -1 to quit): ");
        number = double.Parse(Console.ReadLine());
        while (number != -1.0)
        {
            double ints = RoundToInteger(number);
            double tenths = RoundToTenths(number);
            double hundredths = RoundToHundredths(number);
            double thousandths = RoundToThousandths(number);

            Console.WriteLine($"Number: {number}");
            Console.WriteLine($"Rounded to Integer: {ints}");
            Console.WriteLine($"Rounded to Tenths: {tenths}");
            Console.WriteLine($"Rounded to Hundredths: {hundredths}");
            Console.WriteLine($"Rounded to Thousandths: {thousandths}");

            Console.Write("\nEnter a double value (or -1 to quit): ");
            number = double.Parse(Console.ReadLine());
        }


    }

    static double RoundToInteger(double value) => Math.Floor(value + 0.5);
    static double RoundToTenths(double value) => Math.Floor(value * 10 + 0.5) / 10;
    static double RoundToHundredths(double value) => Math.Floor(value * 100 + 0.5) / 100;
    static double RoundToThousandths(double value) => Math.Floor(value * 1000 + 0.5) / 1000;



}

