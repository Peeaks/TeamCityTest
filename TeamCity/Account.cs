using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamCity {
    public class Account {
        public void Deposit(decimal amount) {
            Balance += amount;
        }

        public void Withdraw(decimal amount) {
            Balance -= amount;
        }

        public void TransferFunds(Account destination, decimal amount) {
            Withdraw(amount);
            destination.Deposit(amount);
        }

        public decimal Balance { get; private set; }
    }
}