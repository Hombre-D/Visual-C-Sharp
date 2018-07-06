using System;


class FiveNumbers
{
    static void Main(string[] args)
    {
        var values = new int[5];
        int counter = 0;

        for (int i = 0; i <= 4; ++i)
        {
            int input;
            bool isDuplicate = false;

            do
            {
                Console.Write("Enter an integer between 10 and 100: ");
                input = int.Parse(Console.ReadLine());
            } while (input < 10 || input > 100 );

            for (int j = 0; j <= i; j++)
            {
                if (input == values[j]) {
                    Console.WriteLine("Duplicate Input");
                    isDuplicate = true;
                }
                
            }

            
            if (isDuplicate == false)
            {   
                values[counter] = input;
                ++counter;
            }

            Console.WriteLine($"Numbers Entered: {i + 1}");
            for (int k = 0; k < counter; ++k)
                Console.Write($"{values[k]} ");
            Console.WriteLine();

        }

    }
}

