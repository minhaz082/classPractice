using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUI
{
    class Account
    {
        public string AccountNo { set; get; }
        public string OpeningDate { set; get; }
        public double Balance { private set; get; }

        public Account(string accountNo, string openingDate)
        {
            AccountNo = accountNo;
            OpeningDate = openingDate;
        }

        public string Withdraw(double amount)
        {
            if (Balance - amount <= 0)
            {
                return "Insufficent balance";
            }
            else
            {
                Balance -= amount;
                return "Withdraw Completed";
            }
        }

        public string Deposit(double amount)
        {
            Balance += amount;
            return "Deposit Completed";
        }
    }
}
