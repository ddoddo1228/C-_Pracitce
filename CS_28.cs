using System;
using System.Threading;

class Account
{
    private double balance;

    public Account(double initialDeposit)
    {
        balance = initialDeposit;
    }

    public double Balance
    {
        get { return balance; }
    }

    public void Deposit(double amount)
    {
        lock (this)
        {
            balance += amount;
        }
    }
}

class Teller
{
    string name;
    Account account;
    double amount;

    public Teller(string name, Account account, double amount)
    {
        this.name = name;
        this.account = account;
        this.amount = amount;
    }

    public void TellerTask()
    {
        account.Deposit(amount);
        Console.WriteLine(name + " : " + account.Balance);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Account account = new Account(1000.0);
        Teller teller1 = new Teller("Teller 1", account, 200.0);
        Teller teller2 = new Teller("Teller 2", account, 300.0);

        Thread thread1 = new Thread(teller1.TellerTask);
        Thread thread2 = new Thread(teller2.TellerTask);

        thread1.Start();
        thread2.Start();

        thread1.Join();
        thread2.Join();

        Console.WriteLine("Final Balance: " + account.Balance);
    }
}
