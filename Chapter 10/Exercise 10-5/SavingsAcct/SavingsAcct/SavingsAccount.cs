using System;

class SavingsAccount
{
    public static decimal AnnualInterestRate { get; private set; }
    public decimal SavingsBalance { get; set; }

    public SavingsAccount(decimal savings)
    {
        SavingsBalance = savings;
    }

    public void CalculateMonthlyInterest()
    {
        decimal interest = this.SavingsBalance * AnnualInterestRate / 12;
        this.SavingsBalance += interest;
    }

    public static void SetInterestRate(decimal rate)
    {
        AnnualInterestRate = rate;
    }

}

