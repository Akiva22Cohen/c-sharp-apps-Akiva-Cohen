using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_Akiva_Cohen.bank_app
{
    public class Account
    {
        private Owner owner;
        private double balance;
        private int overdraft;
        private const double MAX_OVERDRAFT = 90_000;

        public Account(Owner owner, double balance, int overdraft)
        {
            this.owner = owner;
            this.balance = balance;
            SetOverdraft(overdraft);
        }

        public Owner GetOwner() { return owner; }
        public double GetBalance() { return balance; }
        public int GetOverdraft() { return overdraft; }

        public void SetOverdraft(int overdraft)
        {
            if (overdraft < MAX_OVERDRAFT)
                this.overdraft = overdraft;
            else
                Console.WriteLine("You cannot do overdraft more then " + MAX_OVERDRAFT);
        }

        public void Deposit(double amount) { this.balance += amount; }
        public void Withdraw(double amount)
        {
            if (amount < overdraft + balance)
                this.balance -= amount;
            else
                Console.WriteLine("You cannot exceed the overdraft");
        }
    }
}
