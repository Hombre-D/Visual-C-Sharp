using System;


class ParkingCharge
{
    static void Main(string[] args)
    {
        double hours;
        decimal charge, total = 0.0m;
        Console.WriteLine("Welcome to the Parking Charge Calculator.");
        Console.Write("Enter customer hours (or -1 to quit): ");
        hours = double.Parse(Console.ReadLine());
        while (hours != -1)
        {
            charge = CalculateCharge(hours);
            total += charge;
            Console.WriteLine($"Customer hours parked: {hours}");
            Console.WriteLine($"Customer charge: {charge:F}");
            Console.WriteLine($"Total charges: {total:F}");
            Console.Write("\nEnter customer hours (or -1 to quit): ");
            hours = double.Parse(Console.ReadLine());
        }
    }

    public static decimal CalculateCharge(double hours)
    {
        decimal currentCharge = 2.0m;
        for (int i = 3; i < Math.Ceiling(hours); ++i)
        {
            currentCharge += 0.5m;
        }

        return currentCharge;

    }
}

