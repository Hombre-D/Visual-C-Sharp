using System;


class Program
{
    static void Main(string[] args)
    {
        decimal totalSales = 0.0m;
        decimal weeklyPay = 0.0m;

        int item1, item2, item3, item4;

        Console.Write("Enter # sold for Item 1: ");
        item1 = int.Parse(Console.ReadLine());
        totalSales += item1 * 239.99m;
        Console.Write("Enter # sold for Item 2: ");
        item2 = int.Parse(Console.ReadLine());
        totalSales += item2 * 129.75m;
        Console.Write("Enter # sold for Item 3: ");
        item3 = int.Parse(Console.ReadLine());
        totalSales += item3 * 99.95m;
        Console.Write("Enter # sold for Item 4: ");
        item4 = int.Parse(Console.ReadLine());
        totalSales += item4 * 350.89m;

        weeklyPay = 200 + totalSales * .09m;

        Console.WriteLine($"Total Sales: {totalSales:C}");
        Console.WriteLine($"Weekly Pay: {weeklyPay:C}");




    }
}

