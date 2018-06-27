using System;


class PrimeTest
{
    static void Main(string[] args)
    {
        int a;
        Console.WriteLine("Welcome to Prime Finder!");
        Console.Write("Enter an integer: ");
        a = int.Parse(Console.ReadLine());
        if (IsPrime(a))
        {
            Console.WriteLine("Number is prime!");
        }
        else
        {
            Console.WriteLine("Number is not prime!");
        }
    }

    static bool IsPrime(int a)
    {
        if (a <= 1) return false;
        if (a == 2) return true;
        if (a % 2 == 0) return false;

        var boundary = (int)Math.Floor(Math.Sqrt(a));

        for(int i = 3; i < boundary; i += 2)
        {
            if (a % i == 0) return false;
        }

        return true;
    }
}

