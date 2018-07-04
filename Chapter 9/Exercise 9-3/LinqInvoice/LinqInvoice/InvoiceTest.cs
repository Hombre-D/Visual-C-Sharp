using System;
using System.Linq;


class InvoiceTest
{
    static void Main(string[] args)
    {
        var invoices = new[] {new Invoice(83, "Electric sander", 7, 57.98m),
        new Invoice(24, "Power saw", 18, 90.99m),
        new Invoice(7, "Sledge hammer", 11, 21.50m),
        new Invoice(77, "Hammer", 76, 11.99m),
        new Invoice(39, "Lawn mower", 3, 79.50m),
        new Invoice(68, "Screwdriver", 106, 6.99m),
        new Invoice(56, "Jig saw", 21, 11.00m),
        new Invoice(3, "Wrench", 34, 7.50m)};

        //Use LINQ to sort the Invoice Objects by PartDescription
        var sortedByPartDesc =
            from i in invoices
            orderby i.PartDescription
            select i;

        Console.WriteLine("Sorted by Part Description:");
        foreach (var item in sortedByPartDesc)
            Console.WriteLine(item);
        Console.WriteLine();

        //Use LINQ to sort the Invoice Objects by price
        var sortedByPrice =
            from i in invoices
            orderby i.Price
            select i;

        Console.WriteLine("Sorted by Price:");
        foreach (var item in sortedByPrice)
            Console.WriteLine(item);
        Console.WriteLine();

        //Use LINQ to select PartDescription and Quantity and sort the results by quantity
        var quantities =
            from i in invoices
            orderby i.Quantity
            select new { i.PartDescription, i.Quantity };

        Console.WriteLine("Selected Part/Quantity: ");
        foreach (var item in quantities)
            Console.WriteLine($"{item.PartDescription, -25} {item.Quantity, 5}");
        Console.WriteLine();

        //Use LINQ to select the Part Description and the value (Quantity * Price)
        var totalInvoice =
            from i in invoices
            let InvoiceTotal = i.Price * i.Quantity
            orderby InvoiceTotal
            select new { i.PartDescription, invoiceTotal = InvoiceTotal};

        Console.WriteLine("Selected by Part Description and Total Invoice Value:");
        foreach (var item in totalInvoice)
            Console.WriteLine($"{item.PartDescription, -25} {item.invoiceTotal, 5}");
        Console.WriteLine();

        //Use LINQ to select the Invoice Totals between $200 and $500
        var selectedInvoice =
            from t in totalInvoice
            where t.invoiceTotal >= 200 && t.invoiceTotal <= 500
            orderby t.invoiceTotal
            select t;

        Console.WriteLine("Selected where Invoice Value > 200 and < 500:");
        foreach (var item in selectedInvoice)
            Console.WriteLine($"{item.PartDescription,-25} {item.invoiceTotal,5}");
        Console.WriteLine();
           
    }

}

