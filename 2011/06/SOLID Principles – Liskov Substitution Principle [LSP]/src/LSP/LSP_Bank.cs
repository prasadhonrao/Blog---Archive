namespace LSP_Bank
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            Account acc = new Account(1);
            bank.Withdraw(acc, 100);

            Account saving = new SavingAccount(2);
            bank.Withdraw(saving, 100);
        }
    }

    public class Bank
    {
        public virtual void Withdraw(Account acc, int amount)
        {
            acc.Withdraw(acc.Id, amount);
        }
    }

    public class Account
    {
        public Account(int AccountId)
        {
            this.Id = AccountId;
        }

        public virtual int Id { get; set; }

        public virtual void Withdraw(int accountId, int amount)
        {
            Console.WriteLine("In base withdraw");
        }
    }

    public class SavingAccount : Account
    {
        public SavingAccount(int savingAccountId)
            : base(savingAccountId)
        {

        }

        public override void Withdraw(int accountId, int amount)
        {
            Console.WriteLine("In SavingAccount withdraw");
            base.Withdraw(accountId, amount);
        }
    }

    public class CheckingAccount : Account
    {
        public CheckingAccount(int checkingAccountId)
            : base(checkingAccountId)
        {
        }

        public override void Withdraw(int accountId, int amount)
        {
            Console.WriteLine("In CheckingAccount withdraw");
            base.Withdraw(accountId, amount);
        }
    }
}
