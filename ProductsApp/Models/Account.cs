using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductsApp471.Models
{
    public class Account
    {
        public double Balance { get; private set; }

        public double OverdaftLimit { get; private set; }


        public Account(double overdraftLimit) {
            this.OverdaftLimit = overdraftLimit > 0 ? overdraftLimit : 0;
            this.Balance = 0;
        }


        public bool Deposit(double amount) {
            if (amount >= 0) {
                this.Balance += amount;
                return true;
            }
            return false;
        }

        public bool Withdraw(double amount) {
            if (this.Balance - amount >= -this.OverdaftLimit && amount >= 0) {
                this.Balance -= amount;
                return true;
            }
            return false;
        }
    }
}