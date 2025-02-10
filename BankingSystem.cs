using System;
using System.Collections.Generic;
namespace BankingSystem
{
    interface ILoanable
    {
        void ApplyForLoan();
        bool CalculateLoanEligibility();
    }
    abstract class BankAccount
    {
        private int accountNumber;
        private string holderName;
        private double balance;
        public int AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }
        public string HolderName
        {
            get { return holderName; }
            set { holderName = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        protected BankAccount(int accountNumber, string holderName, double balance)
        {
            this.accountNumber = accountNumber;
            this.holderName = holderName;
            this.balance = balance;
        }
        public void Deposit(double amount)
        {
            balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient balance!");
            }
        }
        public abstract double CalculateInterest();
        public virtual void DisplayDetails()
        {
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Holder Name: " + holderName);
            Console.WriteLine("Balance: $" + balance);
        }
    }
    class SavingsAccount : BankAccount
    {
        private double interestRate;

        public SavingsAccount(int accountNumber, string holderName, double balance, double interestRate)
            : base(accountNumber, holderName, balance)
        {
            this.interestRate = interestRate;
        }
        public override double CalculateInterest()
        {
            return Balance * interestRate;
        }
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Account Type: Savings");
            Console.WriteLine("Interest Rate: " + interestRate);
        }
    }
    class CurrentAccount : BankAccount, ILoanable
    {
        private double overdraftLimit;

        public CurrentAccount(int accountNumber, string holderName, double balance, double overdraftLimit)
            : base(accountNumber, holderName, balance)
        {
            this.overdraftLimit = overdraftLimit;
        }
        public override double CalculateInterest()
        {
            return 0; 
        }
        public void ApplyForLoan()
        {
            Console.WriteLine("Loan application submitted.");
        }
        public bool CalculateLoanEligibility()
        {
            return Balance > 5000;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Account Type: Current");
            Console.WriteLine("Overdraft Limit: " + overdraftLimit);
        }
    }

    class Program
    {
        static void Main()
        {
            List<BankAccount> accounts = new List<BankAccount>
            {
                new SavingsAccount(1, "Vatsal", 15000, 0.03),
                new CurrentAccount(2, "Ramesh", 70000, 2000)
            };
            foreach (BankAccount account in accounts)
            {
                account.DisplayDetails();
                Console.WriteLine("Calculated Interest: " + account.CalculateInterest());

                if (account is ILoanable loanableAccount)
                {
                    loanableAccount.ApplyForLoan();
                    Console.WriteLine("Loan Eligibility: " + loanableAccount.CalculateLoanEligibility());
                }

                Console.WriteLine();
            }
        }
    }