using System;

class HypotenuseCalculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the hypotenuse calculator");
        Console.Write("Enter the length of side A: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter the length of side B: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine($"\nThe length of the hypotenuse is: {Hypotenuse(a, b):F}");

    }

    static double Hypotenuse(double a, double b) => 
        Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
}

