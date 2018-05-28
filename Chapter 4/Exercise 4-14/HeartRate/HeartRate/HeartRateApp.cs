//Exercise 4-14 - Heart Rate App
using System;

class HeartRateApp
{
    static void Main(string[] args)
    {
        Console.Write("Enter First Name: ");
        string firstName = Console.ReadLine();
        Console.Write("Enter Last Name: ");
        string lastName = Console.ReadLine();
        Console.Write("Enter year of birth: ");
        int birthYear = int.Parse(Console.ReadLine());
        int currentYear = DateTime.Now.Year;

        HeartRates heartRate = new HeartRates(firstName, lastName, birthYear, currentYear);

        Console.WriteLine($"Name: {heartRate.FirstName} {heartRate.LastName}");
        Console.WriteLine($"Birth Year: {heartRate.BirthYear}");
        Console.WriteLine($"Age: {heartRate.Age}");
        Console.WriteLine($"Max Heart Rate: {heartRate.MaxHeartRate}");
        Console.WriteLine($"Min Target Rate: {heartRate.MinTargetRate}");
        Console.WriteLine($"Max Target Rate: {heartRate.MaxTargetRate}");
        Console.WriteLine("Exercise Safely!");

    }
}

