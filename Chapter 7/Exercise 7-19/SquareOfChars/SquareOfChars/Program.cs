using System;


class Program
{
    static void Main(string[] args)
    {
        int side;
        char symbol;
        Console.Write("Enter an integer: ");
        side = int.Parse(Console.ReadLine());
        Console.Write("Enter a single character: ");
        symbol = char.Parse(Console.ReadLine());
        SquareOfChars(side, symbol);
    }

    static void SquareOfChars(int side, char symbol)
    {
        for (int i = 0; i < side; ++i)
        {
            for (int j = 0; j < side; ++j)
            {
                Console.Write($"{symbol}");
            }
            Console.Write("\n");
        }
    }

}
