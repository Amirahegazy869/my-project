using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;

namespace GitTest
{
    public class BankAcount //PascelCase
    {
        private decimal _Balance; //Backing field 
        public int AccountNumber { get; set; }   // (Auto property)
        public required string OwnerName { get; set; }
        public const string BankName = "cairo bank ";//constant field
        public static readonly decimal MinimumopeningBalance = 500.00m;
        public static int totaleacountsopened;// static property
        private static  int _nextAccountNumber; // static readonly field
        public decimal Balance // full property
        {
            get { return _Balance; }
            set { _Balance = value; }
        }
        //[SetsRequiredMembers]
        //overloaded constructor
        public BankAcount(string ownerName, decimal opiningbalance)
        {
            AccountNumber = _nextAccountNumber;
            _nextAccountNumber++;
            totaleacountsopened++;
            Console.WriteLine("Bankaccount constructor  with 2 arguments called.");
            OwnerName = ownerName;
            Balance = opiningbalance;
        }
        //[SetsRequiredMembers]
        public BankAcount(string ownerName) : this(ownerName, 500.00m)
        {
            Console.WriteLine("Bankaccount constructor  with 1 arguments called");
        }
        //[SetsRequiredMembers]
        public BankAcount() : this("Default Owner", 500.00m)
        {
        }
        //overloading method
        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposit of {amount:F2}EGP in acount {AccountNumber}  New balance: {Balance:f2}EGP");

        }
        public void applymonthlyfee(decimal fee = 500.00m)
        {
            Balance -= fee;
            Console.WriteLine($"Monthly fee of {fee:F2}EGP applied. New balance: {Balance:f2}EGP");
        }
        //public bool Deposit(decimal amount, string description)
        //{
        //    Deposit(amount);
        //    Console.WriteLine($"Description: {description}");
        //}
        public void Transfer(BankAcount destination, decimal amount)
        {
            if (destination == null)
            {
                Console.WriteLine("Destination account cannot be null.");
                return;
            }
            if (amount <= 0m)
            {
                Console.WriteLine("Transfer amount must be positive.");
                return;
            }
            if (amount > Balance)
            {
                Console.WriteLine($"Transfer of {amount:F2}EGP failed. Insufficient funds.");
                return;
            }

            Balance -= amount;
            destination.Deposit(amount);
            Console.WriteLine($"Transfer of {amount:F2}EGP from account {AccountNumber} to account {destination.AccountNumber} completed. New balance: {Balance:f2}EGP");
        }
                    public bool withdraw(decimal amount)
       {
           if (amount <= 0)
            {
               Console.WriteLine($"acount most be positive.");
                return false; 
            }
           if (amount > Balance)
            {
                Console.WriteLine($" Withdrawal of {amount:F2}EGP failed.");
               return false;
            }
            else
           {
               Balance -= amount;
              Console.WriteLine($"Withdrawal of {amount:F2}EGP ");
             return true;
          }
         }
        public string GetSummary()
        {
            return $" {AccountNumber}| {OwnerName} |  {Balance:f2}EGP";
        }
        public static string getbankinfo()
        {
            return $"Bank Name: {BankName}, Minimum Opening Balance: {MinimumopeningBalance:f2}EGP, Total Accounts Opened: {totaleacountsopened}";
        }
        internal void Deposit(decimal amount, string note)
        {
            Deposit(amount);
            Console.WriteLine($"Note: {note}");
        }
        static BankAcount()
        {
            _nextAccountNumber = 1001; // Initialize the static readonly field
            Console.WriteLine($"BankAcount static constructor : {BankName}");
        }
    }
}

