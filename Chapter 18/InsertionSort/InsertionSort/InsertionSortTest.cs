﻿using System;


class InsertionSortTest
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

        InsertionSort(data);

        Console.WriteLine("Sorted array:");
        Console.WriteLine(string.Join(" ", data) + "\n");

    }


    public static void InsertionSort(int[] values)
    {
        for (var next = 1; next < values.Length; ++next)
        {
            var insert = values[next];
            var moveItem = next;

            while(moveItem > 0 && values[moveItem - 1] > insert)
            {
                values[moveItem] = values[moveItem - 1];
                moveItem--;
            }

            values[moveItem] = insert;
            PrintPass(values, next, moveItem);

        }

    }


    public static void PrintPass(int[] values, int pass, int index)
    {
        Console.Write($"after pass {pass}: ");

        for (var i = 0; i < index; ++i)
        {
            Console.Write($"{values[i]} ");
        }

        Console.Write($"{values[index]}*");

        for (var i = index + 1; i < values.Length; ++i)
        {
            Console.Write($"{values[i]} ");
        }

        Console.Write("\n              ");

        for (var i = 0; i <= pass; ++i)
        {
            Console.Write("-- ");
        }

        Console.WriteLine("\n");
    }

}

