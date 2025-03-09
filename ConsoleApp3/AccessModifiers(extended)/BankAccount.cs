using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class BankAccount
    {

        private string _accountHolder;
        private decimal _balance;
        private static int _idCounter = 0;
        public string AccountHolder
        {
            get { return _accountHolder; }
            set { _accountHolder = value; }
        }
         public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        public int ID { get; }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }

        public BankAccount(string accountHolder, decimal balance)
        {
            ID=++_idCounter;
            _accountHolder = accountHolder;
            _balance = balance;
        }
    }
}
