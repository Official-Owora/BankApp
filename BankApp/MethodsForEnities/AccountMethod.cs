using BankApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.MethodsForEnities
{
    public class AccountMethod
    {
        public List<Account> Accounts { get; set; }
        public AccountMethod(List<Account> accounts) 
        {
            Accounts = accounts;
        }
        public Account NewAccount()
        {
            Console.WriteLine("Enter your FirstName and LastName: ");
            string[] nameOfNewAccount = Console.ReadLine().Trim().Split(' ');
            bool isValid = false;
            Console.WriteLine("Enter your Account Type:");
            string AccountType = Console.ReadLine();
            Account account = new Account();
            account.FirstName = nameOfNewAccount[0];
            account.LastName = nameOfNewAccount[1];
            account.AccountType = AccountType;
            Accounts.Add(account);
            return account;
        }
        

    }
}
