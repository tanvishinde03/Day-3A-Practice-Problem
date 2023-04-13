using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3A_Practice_Problem
{
    public class BankAccount
    {
        private string accountNumber;
        private decimal balance;

        public BankAccount(string accountNumber, decimal balance)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient balance!");
            }
        }

        public void DisplayBalance()
        {
            Console.WriteLine($"Account number: {accountNumber}");
            Console.WriteLine($"Balance: {balance}");
        }
    }
}

