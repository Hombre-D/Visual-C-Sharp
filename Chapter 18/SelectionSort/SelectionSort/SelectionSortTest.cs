using System;


public class SelectionSortTest
{
    static void Main(string[] args)
    {
        var generator = new Random();
        var data = new int[10];

        for (var i = 0; i < data.Length; ++i)
        {
            data[i] = generator.Next(10, 100);
        }

        Console.WriteLine("Unsorted array:");
        Console.WriteLine(string.Join(" ", data) + "\n");

        SelectionSort(data);

        Console.WriteLine("Sorted array: ");
        Console.WriteLine(string.Join(" ", data) + "\n");

    }

    public static void SelectionSort(int[] values)
    {
        for (var i = 0; i < values.Length - 1; ++i)
        {
            var smallest = i;

            for (var index = i + 1; index < values.Length; ++index)
            {
                if (values[index] < values[smallest])
                {
                    smallest = index;
                }
            }

            Swap(ref values[i], ref values[smallest]);
            PrintPass(values, i + 1, smallest);
        }
    }
    
    public static void Swap(ref int first, ref int second)
    {
        var temporary = first;
        first = second;
        second = temporary;
    }

    public static void PrintPass(int[] values, int pass, int index)
    {
        Console.Write($"after pass: {pass}: ");

        for (var i = 0; i < index; ++i)
        {
            Console.Write($"{values[i]} ");
        }

        Console.Write($"{values[index]} ");

        for (var i = index + 1; i < values.Length; ++i)
        {
            Console.Write($"{values[i]} ");
        }

        Console.Write("\n               ");

        for(var j = 0; j < pass; ++j)
        {
            Console.Write("-- ");
        }

        Console.WriteLine("\n");
    }
}

