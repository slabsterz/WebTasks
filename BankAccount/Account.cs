using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Account
    {
        public string AccountNumber { get; set; }

        public string AccountHolder { get; set; }

        public decimal Balance { get; set; }

        public Account(string accountNumber, string accountHolder, decimal balance)
        {
            this.AccountNumber = accountNumber;
            this.AccountHolder = accountHolder;
            this.Balance = balance;
        }

        public void Deposit(decimal amount) 
        {
            Balance += amount;
        }

        public void Withdrawal(decimal amount)
        {          

            if (amount > Balance)
            {
                Console.WriteLine("Not enough money in the account to complete this action.");
            }
            else
            {
                Balance -= amount;
            }
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine($"Account number: {AccountNumber}");
            Console.WriteLine($"Account holder: {AccountHolder}");
            Console.WriteLine($"Account balance: {Balance}");
        }

    }
}
