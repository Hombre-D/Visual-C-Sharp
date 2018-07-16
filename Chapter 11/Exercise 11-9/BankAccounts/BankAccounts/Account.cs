using System;


public class Account
{
    private decimal balance;

    public Account(decimal balance)
    {
        Balance = balance;
    }

    public decimal Balance
    {
        get
        {
            return balance;
        }

        set
        {
            if(value < 0.0m)
            {
                throw new ArgumentOutOfRangeException(nameof(value), value,
                    $"{nameof(Balance)} may not be negative.");
            }
            balance = value;
        }
    }

    public virtual void Credit(decimal amount)
    {
        if (amount < 0.0m)
        {
            Console.WriteLine("Amount to credit should not be negative.");
        }
        else
        {
            Balance += amount;
        }
    }

    public virtual bool Debit(decimal amount)
    {
        if (amount < 0.0m)
        {
            Console.WriteLine("Amount to debit should not be negative.");
            return false;
        }
        else
        {
            if(Balance - amount < 0.0m)
            {
                Console.WriteLine("Debit amount exceeded account balance.");
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }
    }

}

