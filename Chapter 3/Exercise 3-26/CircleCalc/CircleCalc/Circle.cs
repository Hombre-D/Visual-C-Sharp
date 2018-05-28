using System;


class Circle
{
    static void Main(string[] args)
    {
        Console.Write("Enter the radius of the circle as an int value: ");
        int radius = int.Parse(Console.ReadLine());
        Console.WriteLine($"Diameter: {2 * radius}");
        Console.WriteLine($"Circumference: {2 * Math.PI * radius}");
        Console.WriteLine($"Area: {Math.PI * (Math.Pow((double) radius, 2))}");
    }
}

