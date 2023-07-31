using System;

class Account
{
    private int accountID;
    private double accountBalance;
    private static int count = 0;

    public Account()
    {
        accountID = ++count;
        accountBalance = 0;
    }

    public Account(double initialBalance)
    {
        accountID = ++count;
        accountBalance = initialBalance;
    }

    public void deposit(double amount)
    {
        accountBalance += amount;
    }

    public void withdraw(double amount)
    {
        if (amount <= accountBalance)
            accountBalance -= amount;
        else
            Console.WriteLine("Insufficient balance.");
    }

    public void showAccountInfo()
    {
        Console.WriteLine($"Account ID: {accountID}");
        Console.WriteLine($"Account Balance: {accountBalance}");
    }

    public void transferMoney(Account targetAccount, double amount)
    {
        if (amount <= accountBalance)
        {
            accountBalance -= amount;
            targetAccount.deposit(amount);
        }
        else
        {
            Console.WriteLine("Insufficient balance for transfer.");
        }
    }

    public static void showAccountCount()
    {
        Console.WriteLine($"Total Accounts: {count}");
    }
}

class Program
{
    static void Main()
    {
        Account acc1 = new Account();
        Account acc2 = new Account(1000);

        acc1.deposit(500);
        acc2.withdraw(200);
        acc1.transferMoney(acc2, 300);

        acc1.showAccountInfo();
        acc2.showAccountInfo();

        Account.showAccountCount(); // Will display the total number of accounts created so far
    }
}
