using System;


class HealthProfileApp
{
    static void Main(string[] args)
    {
        string firstName;
        string lastName;
        string gender;
        int birthMonth;
        int birthDay;
        int birthYear;
        int height;
        int weight;

        Console.Write("Enter First Name: ");
        firstName = Console.ReadLine();
        Console.Write("Enter Last Name: ");
        lastName = Console.ReadLine();
        Console.Write("Enter gender (M or F): ");
        gender = Console.ReadLine();
        Console.Write("Enter Birth Month (1-12): ");
        birthMonth = int.Parse(Console.ReadLine());
        Console.Write("Enter Birth Day (1-31): ");
        birthDay = int.Parse(Console.ReadLine());
        Console.Write("Enter Birth Year: ");
        birthYear = int.Parse(Console.ReadLine());
        Console.Write("Enter Height (in inches): ");
        height = int.Parse(Console.ReadLine());
        Console.Write("Enter Weight (in pounds): ");
        weight = int.Parse(Console.ReadLine());

        HealthProfile healthProfile = new HealthProfile(firstName, lastName, gender, birthMonth,
            birthDay, birthYear, height, weight);

        Console.WriteLine($"\nHello, {healthProfile.FirstName} {healthProfile.LastName}");
        Console.WriteLine($"Gender: {healthProfile.Gender}");
        Console.WriteLine($"Date of Birth: {healthProfile.BirthMonth}/{healthProfile.BirthDay}/{healthProfile.BirthYear}");
        Console.WriteLine($"Height: {healthProfile.Height}");
        Console.WriteLine($"Weight: {healthProfile.Weight}");
        Console.WriteLine($"Age: {healthProfile.getAge()}");
        Console.WriteLine($"Maximum Heart Rate: {healthProfile.getMaxHeartRate()}");
        Console.WriteLine($"Target Heart Rate Range: {healthProfile.getMinTargetRate()}/{healthProfile.getMaxTargetRate()}");
        Console.WriteLine($"BMI: {healthProfile.getBMI():F}\n");

        Console.WriteLine("BMI Values");
        Console.WriteLine("Underweight:\tless than 18.5");
        Console.WriteLine("Normal:\t\tbetween 18.5 and 24.9");
        Console.WriteLine("Overweight:\tbetween 25 and 29.9");
        Console.WriteLine("Obese:\t\t30 or greater\n");

    }
}

