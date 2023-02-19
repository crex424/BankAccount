using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    /// <summary>
    ///  Represents a single customers bank account
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Creates an account with specific owner and a balance of 0
        /// </summary>
        /// <param name="accountOwner">The customer full name that owns account</param>
        public Account(string accountOwner)
        {
            Owner = accountOwner;
        }

        /// <summary>
        /// The account holders full name (first last)
        /// </summary>
        public string Owner { get; set; }
        /// <summary>
        /// The amount of money in the account
        /// </summary>
        public double Balance { get; private set; }
        /// <summary>
        /// Add a specified amount of money to account. Returns the new balance
        /// </summary>
        /// <param name="amount">The positive amount to deposit</param>
        /// <returns>The new balance</returns>
        public double Deposit(double amount)
        {
            Balance += amount;
            return Balance;
        }
        /// <summary>
        /// Withdraws an amount of money from the balance
        /// </summary>
        /// <param name="amount">  The positive amount of money to be removed from the balance</param>
        public void Withdraw(double amount)
        {
            throw new NotImplementedException();
        }
    }
}
