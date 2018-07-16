using System;


public class CheckingAccount : Account
{
    private decimal feePerTransaction;

    public CheckingAccount(decimal balance, decimal feePerTransaction): base(balance)
    {
        FeePerTransaction = feePerTransaction;
    }

    public decimal FeePerTransaction { get; set; }

    public override void Credit(decimal amount)
    {
        base.Credit(amount);
        Balance -= FeePerTransaction;
    }

    public override bool Debit(decimal amount)
    {
        if (base.Debit(amount))
        {
            Balance -= FeePerTransaction;
            return true;
        }

        else return false;
            
    }
}

