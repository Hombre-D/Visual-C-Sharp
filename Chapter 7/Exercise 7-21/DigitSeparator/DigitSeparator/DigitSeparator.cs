using System;


class DigitSeparator
{
    static void Main(string[] args)
    {
        Console.Write("Enter an integer between 1 and 99999: ");
        int input = int.Parse(Console.ReadLine());
        DisplayDigits(input);
        
    }

    static void DisplayDigits(int a)
    {
        bool firstDigit = false;
        for (int i = 10000; i >= 1;)
        {
            int digit = a / i;
            int remainder = a % i;
            i = i / 10;
            if(digit == 0 && firstDigit == false)
            {

            }
            else
            {
                Console.Write($"{digit}  ");
                firstDigit = true;
            }
            
            a = remainder;
        }
        Console.WriteLine("");
    }

}

