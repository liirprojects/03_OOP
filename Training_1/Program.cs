using System;

namespace Training_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount1 = new BankAccount(10904690);
            bankAccount1.TopUpMethod(200);
            bankAccount1.WithDrawMoney(20);

            Console.ReadKey();
        }
    }
    class BankAccount
    {
        private double balance;
        private uint accountnumber;

        private DateTime dateTime;

        public BankAccount(uint account)
        {
            Console.WriteLine("Initial balance of the card : 0.00");
            this.accountnumber = account;     

            dateTime = DateTime.Now;
        }

        public double Balance
        {
            private set
            {
                if (value < -100)
                    throw new ArgumentOutOfRangeException("Blance credit can not be less tham 100.00");
                balance = value;
            }
            get {
                return balance;
            }
        }

        public void TopUpMethod(double amount)
        {
            if (amount > 0)
            {
                balance = balance + amount;

                Console.WriteLine("Balance for {0} : [{1}]", dateTime, balance.ToString("F2"));
            }
            else
                Console.WriteLine("Impossible to top up an amount with a negative or 0 values.");
        }

        public void WithDrawMoney(double amount)
        {
            if (amount <= balance && amount > 0)
            {
                balance = balance - amount;
                Console.WriteLine("After withdrawing {0} -- balance for {1} : [{2}]", 
                    amount.ToString("F2"), dateTime, balance.ToString("F2"));
            }
            else
                Console.WriteLine("Balance is less than credit to withdraw or your values is negative");
        }
            
    }
}
