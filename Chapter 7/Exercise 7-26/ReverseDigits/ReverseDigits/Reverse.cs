using System;


class Reverse
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Digit Reverser!");
        Console.Write("Enter an integer: ");
        int input = int.Parse(Console.ReadLine());
        int reverse = Reversed(input);
        Console.WriteLine($"Reversed integer: {reverse}");

    }

    static int Reversed(int a)
    {
        int quotient = a / 10;
        int remainder = a % 10;
        int reverse = remainder;
        while(quotient != 0)
        {
            reverse *= 10;
            remainder = quotient % 10;
            quotient /= 10;
            reverse += remainder;
        }

        return reverse;

    }

}

