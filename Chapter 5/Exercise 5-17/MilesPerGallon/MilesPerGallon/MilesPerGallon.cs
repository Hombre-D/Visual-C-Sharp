using System;


class MilesPerGallon
{
    static void Main(string[] args)
    {
        int gallons;
        int miles;
        double mpg;
        int totalGallons = 0;
        int totalMiles = 0;
        double totalMPG;

        Console.Write("Enter gallons in this tankful (or number < 1 to quit): ");
        gallons = int.Parse(Console.ReadLine());
        while (gallons > 0)
        {
            Console.Write("Enter miles driven in this tankful: ");
            miles = int.Parse(Console.ReadLine());
            mpg = (double)miles / gallons;
            Console.WriteLine($"MPG for this tankful: {mpg:F}");
            totalGallons += gallons;
            totalMiles += miles;
            Console.Write("Enter gallons in the next tankful (or number < 1 to quit): ");
            gallons = int.Parse(Console.ReadLine());
        }

        totalMPG = (double) totalMiles / totalGallons;
        Console.WriteLine($"Total Gallons: {totalGallons}");
        Console.WriteLine($"Total Miles: {totalMiles}");
        Console.WriteLine($"Total MPG: {totalMPG:F}");
        Console.WriteLine("Thanks for checking your MPG with us today!");
    }
}

