﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamCity {
    public class Account {
        private decimal _balance;

        public void Deposit(decimal amount) {
            _balance += amount;
        }

        public void Withdraw(decimal amount) {
            _balance -= amount;
        }

        public void TransferFunds(Account destination, decimal amount) {
            Withdraw(amount);
            destination.Deposit(amount);
        }

        public decimal Balance => _balance;
    }
}
