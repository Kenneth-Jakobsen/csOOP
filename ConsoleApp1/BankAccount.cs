using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class BankAccount(string accountHolder, decimal balance)
    {
        private string AccountHolder { get;set; } = accountHolder;
        public decimal Balance { get; private set; } = balance;


        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }

    }
}
