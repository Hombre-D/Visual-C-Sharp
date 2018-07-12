using System;


class SavingsAccountTest
{
    static void Main(string[] args)
    {
        SavingsAccount saver1 = new SavingsAccount(2000.0m);
        SavingsAccount saver2 = new SavingsAccount(3000.0m);

        SavingsAccount.SetInterestRate(.04m);

        Console.WriteLine($"Saver 1 initial balance: {saver1.SavingsBalance:C}");
        Console.WriteLine($"Saver 2 initial balance: {saver2.SavingsBalance:C}");

        saver1.CalculateMonthlyInterest();
        saver2.CalculateMonthlyInterest();

        Console.WriteLine($"Saver 1 first new balance: {saver1.SavingsBalance:C}");
        Console.WriteLine($"Saver 2 first new balance: {saver2.SavingsBalance:C}");

        SavingsAccount.SetInterestRate(.05m);

        saver1.CalculateMonthlyInterest();
        saver2.CalculateMonthlyInterest();

        Console.WriteLine($"Saver 1 second new balance: {saver1.SavingsBalance:C}");
        Console.WriteLine($"Saver 2 second new balance: {saver2.SavingsBalance:C}");
    }
}

