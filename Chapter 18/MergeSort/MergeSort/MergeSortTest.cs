using System;


public class MergeSortTest
{
    static void Main(string[] args)
    {
        var generator = new Random();
        var data = new int[10];

        for(var i = 0; i < data.Length; ++i)
        {
            data[i] = generator.Next(10, 100);
        }

        Console.WriteLine("Unsorted array:");
        Console.WriteLine(string.Join(" ", data) + "\n");

        MergeSort(data);

        Console.WriteLine("Sorted array:");
        Console.WriteLine(string.Join(" ", data) + "\n");

    }

    public static void MergeSort(int[] values)
    {
        SortArray(values, 0, values.Length - 1);
    }

    private static void SortArray(int[] values, int low, int high)
    {
        if((high - low) >= 1)
        {
            int middle1 = (low + high) / 2;
            int middle2 = middle1 + 1;

            Console.WriteLine($"split:   {Subarray(values, low, high)}");
            Console.WriteLine($"         {Subarray(values, low, middle1)}");
            Console.WriteLine($"         {Subarray(values, middle2, high)}");
            Console.WriteLine();

            SortArray(values, low, middle1);
            SortArray(values, middle2, high);

            Merge(values, low, middle1, middle2, high);
        }
    }

    private static void Merge(int[] values, int left, int middle1, int middle2, int right)
    {
        int leftIndex = left;
        int rightIndex = middle2;
        int combinedIndex = left;
        int[] combined = new int[values.Length];

        Console.WriteLine($"merge:    {Subarray(values, left, middle1)}");
        Console.WriteLine($"          {Subarray(values, middle2, right)}");

        while (leftIndex <= middle1 && rightIndex <= right)
        {
            if(values[leftIndex] <= values[rightIndex])
            {
                combined[combinedIndex++] = values[leftIndex++];
            }
            else
            {
                combined[combinedIndex++] = values[rightIndex++];
            }
        }

        if (leftIndex == middle2)
        {
            while (rightIndex <= right)
            {
                combined[combinedIndex++] = values[rightIndex++];
            }
        }
        else
        {
            while(leftIndex <= middle1)
            {
                combined[combinedIndex++] = values[leftIndex++];
            }
        }

        for(int i = left; i <= right; ++i)
        {
            values[i] = combined[i];
        }

        Console.WriteLine($"          {Subarray(values, left, right)}");
        Console.WriteLine();
    }

    public static string Subarray(int[] values, int low, int high)
    {
        string temporary = string.Empty.PadLeft(low * 3);

        for(int i = low; i <= high; ++i)
        {
            temporary += $" {values[i]}";
        }

        return temporary;
    }
    
}

