using System;
using System.Collections.Generic;

class BankingSystem
{
    private Dictionary<int, double> accountBalances = new Dictionary<int, double>();
    private SortedDictionary<double, List<int>> sortedBalances = new SortedDictionary<double, List<int>>();
    private Queue<Tuple<int, double>> withdrawalQueue = new Queue<Tuple<int, double>>();
    public void AddAccount(int accountId, double initialBalance)
    {
        if (!accountBalances.ContainsKey(accountId))
        {
            accountBalances[accountId] = initialBalance;
            if (!sortedBalances.ContainsKey(initialBalance))
            {
                sortedBalances[initialBalance] = new List<int>();
            }
            sortedBalances[initialBalance].Add(accountId);
        }
        else
        {
            Console.WriteLine("Account already exists.");
        }
    }
    public void RequestWithdrawal(int accountId, double amount)
    {
        withdrawalQueue.Enqueue(new Tuple<int, double>(accountId, amount));
    }
    public void ProcessWithdrawals()
    {
        while (withdrawalQueue.Count > 0)
        {
            var request = withdrawalQueue.Dequeue();
            int accountId = request.Item1;
            double amount = request.Item2;

            if (accountBalances.ContainsKey(accountId))
            {
                double currentBalance = accountBalances[accountId];
                if (currentBalance >= amount)
                {
                    accountBalances[accountId] -= amount;
                    UpdateSortedBalances(accountId, currentBalance, accountBalances[accountId]);
                    Console.WriteLine("Withdrawal of $" + amount + " from account " + accountId + " processed successfully.");
                }
                else
                {
                    Console.WriteLine("Insufficient funds for account " + accountId);
                }
            }
            else
            {
                Console.WriteLine("Account " + accountId + " does not exist.");
            }
        }
    }
    private void UpdateSortedBalances(int accountId, double oldBalance, double newBalance)
    {
        sortedBalances[oldBalance].Remove(accountId);
        if (sortedBalances[oldBalance].Count == 0)
        {
            sortedBalances.Remove(oldBalance);
        }

        if (!sortedBalances.ContainsKey(newBalance))
        {
            sortedBalances[newBalance] = new List<int>();
        }
        sortedBalances[newBalance].Add(accountId);
    }
    public void DisplayAccountBalances()
    {
        Console.WriteLine("Account Balances:");
        foreach (var account in accountBalances)
        {
            Console.WriteLine("Account " + account.Key + ": $" + account.Value);
        }
    }
    public void DisplaySortedBalances()
    {
        Console.WriteLine("Sorted Account Balances:");
        foreach (var kvp in sortedBalances)
        {
            foreach (var accountId in kvp.Value)
            {
                Console.WriteLine("Account " + accountId + ": $" + kvp.Key);
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        BankingSystem bankingSystem = new BankingSystem();
        bankingSystem.AddAccount(101, 1000);
        bankingSystem.AddAccount(102, 1500);
        bankingSystem.AddAccount(103, 500);
        bankingSystem.AddAccount(104, 2000);
        bankingSystem.AddAccount(105, 1000);
        bankingSystem.DisplayAccountBalances();
        bankingSystem.DisplaySortedBalances();
        bankingSystem.RequestWithdrawal(101, 200);
        bankingSystem.RequestWithdrawal(102, 300);
        bankingSystem.RequestWithdrawal(103, 700); // This should fail due to insufficient funds
        bankingSystem.RequestWithdrawal(104, 1500);
        bankingSystem.ProcessWithdrawals();
        bankingSystem.DisplayAccountBalances();
        bankingSystem.DisplaySortedBalances();
    }
}
