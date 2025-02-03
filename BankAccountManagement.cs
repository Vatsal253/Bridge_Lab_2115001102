using System;
namespace BankAccountManagement
{
    class BankAccount
    {
        public int AccountNumber { get; set; }
        protected string AccountHolder { get; set; }
        private double Balance { get; set; }

        public BankAccount(int accountNumber, string accountHolder, double balance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = balance;
        }
        public double GetBalance()
        {
            return Balance;
        }
        public void SetBalance(double balance)
        {
            if (balance >= 0)
            {
                Balance = balance;
            }
            else
            {
                Console.WriteLine("Invalid balance. Please enter a non-negative value.");
            }
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Bank Account Details:");
            Console.WriteLine("Account Number: " + AccountNumber);
            Console.WriteLine("Account Holder: " + AccountHolder);
            Console.WriteLine("Balance: " + Balance);
        }
    }
    class SavingsAccount : BankAccount
    {
        public double InterestRate { get; set; }
        public SavingsAccount(int accountNumber, string accountHolder, double balance, double interestRate)
            : base(accountNumber, accountHolder, balance)
        {
            InterestRate = interestRate;
        }
        public new void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Interest Rate: " + InterestRate + "%");
        }
    }
    class Program
    {
        static void Main()
        {
            BankAccount account = new BankAccount(2134989, "Vatsal", 100000.0);
            account.DisplayDetails();
            account.SetBalance(1200000.0);
            Console.WriteLine("Updated Balance: " + account.GetBalance());
            SavingsAccount savingsAccount = new SavingsAccount(2134008, "Modi", 12222000.0, 2.0);
            savingsAccount.DisplayDetails();
        }
    }
}
