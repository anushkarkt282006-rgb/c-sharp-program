using System.ComponentModel;
using System;

public abstract class Account
{
    protected string AccountHolder;
    protected decimal Balance;

    public Account(string accountHolder, decimal balance)
    {
        AccountHolder = accountHolder;
        Balance = balance;
    }

    public abstract void DisplayAccountInfo();
    
    public virtual void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposited: {amount}");
    }

    public virtual void Withdraw(decimal amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}");
        }
        else
        {
            Console.WriteLine("Insufficient balance");
        }
    }
}

public class SavingsAccount : Account
{
    private decimal InterestRate;

    public SavingsAccount(string accountHolder, decimal balance, decimal interestRate)
        : base(accountHolder, balance)
    {
        InterestRate = interestRate;
    }

    public override void DisplayAccountInfo()
    {
        Console.WriteLine($"Savings Account - Holder: {AccountHolder}, Balance: {Balance}, Interest Rate: {InterestRate}%");
    }
}

public class CurrentAccount : Account
{
    private decimal OverdraftLimit;

    public CurrentAccount(string accountHolder, decimal balance, decimal overdraftLimit)
        : base(accountHolder, balance)
    {
        OverdraftLimit = overdraftLimit;
    }

    public override void Withdraw(decimal amount)
    {
        if (Balance + OverdraftLimit >= amount)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}");
        }
        else
        {
            Console.WriteLine("Exceeds overdraft limit");
        }
    }

    public override void DisplayAccountInfo()
    {
        Console.WriteLine($"Current Account - Holder: {AccountHolder}, Balance: {Balance}, Overdraft Limit: {OverdraftLimit}");
    }
}