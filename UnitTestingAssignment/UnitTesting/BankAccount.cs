using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class BankAccount
    {
        double balance;
        public BankAccount(double bal)
        {
            balance = bal;
        }

        /// <summary>
        /// Amount being debit from the account
        /// </summary>
        /// <param name="amount"></param>
        /// <returns>double</returns>
        public double Debit(double amount)
        {
            if (amount > balance)
                throw new ArgumentOutOfRangeException("amount");
            else if (amount == 0)
                throw new NullReferenceException("amount");
            else if (amount < 0)
                throw new ArgumentOutOfRangeException("amount");
            else if (amount > 5000)
                throw new ArgumentOutOfRangeException("amount");
            else if ((balance - amount) < 1000)
                throw new InvalidOperationException("amount");
            else
            {
                balance -= amount;
                return balance;
            }

        }
    }
}
