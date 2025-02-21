using System;
namespace BankTransactionSystem
{
    public class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(string message) : base(message)
        {
        }
    }

    public class BankAccount
    {
        public double Balance { get; private set; }

        public BankAccount(double initialBalance)
        {
            Balance = initialBalance;
        }

        public void Withdraw(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Invalid amount!");
            }
            if (amount > Balance)
            {
                throw new InsufficientFundsException("Insufficient balance!");
            }
            Balance -= amount;
            Console.WriteLine("Withdrawal successful, new balance: "+Balance);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(1000.00);

            try
            {
                Console.Write("Enter the amount to withdraw: ");
                double amount = double.Parse(Console.ReadLine());
                account.Withdraw(amount);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
