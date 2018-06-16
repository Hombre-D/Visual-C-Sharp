using System;


class Program
{
    static void Main(string[] args)
    {
        int side;
        Console.Write("Enter an integer: ");
        side = int.Parse(Console.ReadLine());
        SquareOfAsterisks(side);
    }

    static void SquareOfAsterisks(int side)
    {
        for (int i = 0; i < side; ++i)
        {
            for (int j = 0; j < side; ++j)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }
    }

}

