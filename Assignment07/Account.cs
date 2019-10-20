using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment07
{
    public class Account
    {
        private double Balance { get; set; }
        public Account(double balance)
        {
            Balance = balance;
        }

        [ContractInvariantMethod]

        public void AccountInvariant()
        {
            Contract.Invariant(Balance >= 0);
        }

        public double Deposite(double amount)
        {
            Contract.Requires<ArgumentException>(amount > 0, nameof(amount));
            Contract.Requires<ArgumentException>(amount <= Contract.OldValue(Balance), nameof(amount));

            if (amount <= 0) throw new ArgumentException($"{nameof(amount)} must be positive");
            Balance += amount;
            return Balance;
        }

        public double Withdrawl(double amount)
        {
            Contract.Requires<ArgumentException>(amount > 0, nameof(amount));
            Contract.Requires<ArgumentException>(amount <= Contract.OldValue(Balance), nameof(amount));

            if (amount <= 0) throw new ArgumentException($"{nameof(amount)} must be positive");

            if (amount > Balance) throw new ArgumentException($"{nameof(amount)} is greater than {nameof(Balance)}");

            Balance -= amount;
            return Balance;
        }


    }
    
}
