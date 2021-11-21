using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            Account account = new Account(1500M);
            account.IncreaseBalance(500);
            SavingAccount savingAccount = new SavingAccount(4000, 100);
            savingAccount.IncreaseInterest(50);

            bank.AddAcount(account);
            bank.AddAcount(savingAccount);

            Console.WriteLine(bank.GetValue());
        }
    }
}
