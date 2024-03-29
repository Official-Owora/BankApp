﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BankApp.Entities
{
    public class Account
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal AccountBalance { get; set; }
        public string AccountType { get; set; }
        List<Transaction> Transactions { get; set; }
    }
}
