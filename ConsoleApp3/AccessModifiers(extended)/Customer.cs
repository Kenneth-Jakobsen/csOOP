using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Customer
    {
        public string Name { get; private set; }
        private List<BankAccount> BankAccounts { get; set; }

        public Customer(string name)
        {
            Name = name;
            BankAccounts = new List<BankAccount>();
        }

        public void AddBankAccount(BankAccount bankAccount)
        {
            BankAccounts.Add(bankAccount);
        }

        public void Withdraw(BankAccount bankAccount, decimal amount)
        {
            bankAccount.Withdraw(amount);
        }

        public void Deposit(BankAccount bankAccount, decimal amount)
        {
            bankAccount.Deposit(amount);
        }

        public void InfoDisplay()
        {
            Console.WriteLine($"Name: {Name}");
            foreach(var BankAccount in BankAccounts)
            {
                Console.WriteLine($"Account {BankAccount.ID} has {BankAccount.Balance}$");
            }
        }
    }
}
