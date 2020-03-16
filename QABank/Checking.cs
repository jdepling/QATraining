using System;

namespace QABank
{
    /// <summary>
    /// This is a checking account
    /// </summary>
    public class Checking : IAccount
    {
        public double Balance { get; set; }

        public string Name { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        public Checking(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Makes a deposit into an account
        /// </summary>
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"{amount} added to balance. Balance is now: {Balance}");
            }
            else
                Console.WriteLine("Amount must be greater than 0");
        }

        /// <summary>
        /// Transfers money from one account to another, if the amount is a valid amount
        /// </summary>
        public void Transfer(double amount, IAccount source, IAccount destination)
        {
            if (amount > 0 && source.Balance >= amount)
            {
                source.Balance      -= amount;
                destination.Balance += amount;
                Console.WriteLine($"{amount} added to {destination.Name}. Balance is now: {destination.Balance}");
                Console.WriteLine($"{amount} taken from {source.Name}. Balance is now: {source.Balance}");
            }
            else
                Console.WriteLine("Ensure the amount entered is greater than 0 AND is less than or equal to your account balance");
        }

        /// <summary>
        /// Withdraws money from this account. If the amount to withdraw is a valid amount.
        /// </summary>
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"{amount} withdrawn from balance. Balance is now: {Balance}");
            }
            else
            {
                Console.WriteLine("Please ensure the amount entered is greater than 0 and is not greater than your account balance.");
            }
        }
    }
}
