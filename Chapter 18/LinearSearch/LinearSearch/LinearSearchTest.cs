using System;


public class LinearSearchTest
{
    static void Main(string[] args)
    {
        var generator = new Random();
        var data = new int[10];

        for (var i = 0; i < data.Length; ++i)
        {
            data[i] = generator.Next(10, 100);
        }

        Console.WriteLine(string.Join(" ", data) + "\n");

        Console.Write("Enter an integer value (-1 to exit): ");
        var searchInt = int.Parse(Console.ReadLine());

        while (searchInt != -1)
        {
            int position = LinearSearch(data, searchInt);

            if(position != -1)
            {
                Console.WriteLine($"The integer {searchInt} was found in position {position}");
            }
            else
            {
                Console.WriteLine($"The integer {searchInt} was not found.\n");
            }

            Console.Write("Enter an integer value (-1 to quit): ");
            searchInt = int.Parse(Console.ReadLine());

        }

    }

    public static int LinearSearch(int[] values, int searchKey)
    {
        for (var index = 0; index < values.Length; ++index)
        {
            if(values[index] == searchKey)
            {
                return index;
            }
        }

        return -1;
    }
}

