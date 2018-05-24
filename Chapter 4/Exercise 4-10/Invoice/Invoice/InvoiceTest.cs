using System;

class InvoiceTest
{
    static void Main(string[] args)
    {
        Invoice invoice1 = new Invoice("12", "Order 1", 4, 5.99m);
        Console.WriteLine($"Part Number: {invoice1.PartNumber}");
        Console.WriteLine($"Description: {invoice1.Description}");
        Console.WriteLine($"Quantity: {invoice1.Quantity}");
        Console.WriteLine($"Price Per Item: {invoice1.PricePerItem}\n");

        Console.Write("Enter a new quantity: ");
        invoice1.Quantity = int.Parse(Console.ReadLine());
        Console.WriteLine($"New Quantity: {invoice1.Quantity}\n");
        Console.Write("Enter a new Price Per Item: ");
        invoice1.PricePerItem = decimal.Parse(Console.ReadLine());
        Console.WriteLine($"New Price Per Item: {invoice1.PricePerItem}\n");
        Console.WriteLine($"Invoice Amount: {invoice1.GetInvoiceAmount()}");

    }
 }

