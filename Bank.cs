﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class Bank
    {
        private List<Account> accounts = new List<Account>();

        public void AddAcount(Account account) 
        {
            accounts.Add(account);
        }

        public decimal GetValue()
        {
            decimal total = 0;
            foreach (Account a in accounts)
            {
                total += a.GetValue();
            }

            return total;
        }

    }
}