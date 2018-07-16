using System;


public class SavingsAccount : Account
{
    private decimal interestRate;

    public SavingsAccount(decimal balance, decimal interestRate): base(balance)
    {
        InterestRate = interestRate;
    }

    public decimal InterestRate
    {
        get
        {
            return interestRate;
        }

        set
        {
            interestRate = value;
        }
    }

    public decimal CalculateInterest()
    {
        return this.InterestRate * this.Balance;
    }

}

