namespace BankApp
{
    public class BankAppMethods
    {
        public static decimal WithdrawalForSavingsAccount(decimal balance, decimal amountToWithdraw)
        {
            if (balance > 1000) 
            {
                balance -= amountToWithdraw;
                return balance;
            }
            else
            {
                Console.WriteLine("Insufficient Fund");
                return balance;
            }
            
        }
        public static decimal WithdrawalForCurrentAccount(decimal balance, decimal amountToWithdraw)
        {
            if(balance >= 0)
            {
                balance -= amountToWithdraw;
                return balance;
            }
            else
            {
                Console.WriteLine("Insufficient Fund");
                return balance;
            }

        }
        public static decimal DepositMoneyToAnyAccount(decimal balance, decimal amount)
        {
            balance += amount;
            return balance;
        }
    }
    public class BankAccountType
    {
        public string AccountName { get; set; }
        public string AccountType { get; }
        public string AccountNumber { get; }
        public decimal Balance { get; }


        public BankAccountType(string accountNumber, string accountName, string accountType, decimal balance)
        {
            AccountNumber = accountNumber;
            AccountName = accountName;
            AccountType = accountType;
            Balance = balance;
            
        }
        
    }   
}