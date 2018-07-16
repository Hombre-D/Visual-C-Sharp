using System;


class AccountTest
{
    static void Main(string[] args)
    {
        CheckingAccount check1 = new CheckingAccount(400.0m, 0.25m);
        Console.WriteLine($"Checking Account Balance: {check1.Balance}");
        check1.Credit(100.0m);
        Console.WriteLine($"Checking Account Balance: {check1.Balance}");
        check1.Debit(-50.0m);
        Console.WriteLine($"Checking Account Balance: {check1.Balance}");
        check1.Debit(50.0m);
        Console.WriteLine($"Checking Account Balance: {check1.Balance}");



    }
}

