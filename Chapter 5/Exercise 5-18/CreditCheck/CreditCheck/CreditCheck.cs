using System;

class CreditCheck
{
    static void Main(string[] args)
    {
        int accountNumber, balance, charges, credits, creditLimit;

        Console.Write("Enter first account number (or -1 to quit): ");
        accountNumber = int.Parse(Console.ReadLine());

        while(accountNumber != -1)
        {
            Console.Write("Enter balance: ");
            balance = int.Parse(Console.ReadLine());
            Console.Write("Enter charges: ");
            charges = int.Parse(Console.ReadLine());
            Console.Write("Enter credits: ");
            credits = int.Parse(Console.ReadLine());
            Console.Write("Enter credit limit: ");
            creditLimit = int.Parse(Console.ReadLine());

            balance += charges - credits;
            Console.WriteLine($"New balance: {balance}");
            if (balance > creditLimit)
            {
                Console.WriteLine("Credit Limit Exceeded!");
            }
            else
            {
                Console.WriteLine("Credit is OK!");
            }

            Console.Write("Enter next account number (or -1 to quit): ");
            accountNumber = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Credit checks completed! Thanks!");

    }
}

