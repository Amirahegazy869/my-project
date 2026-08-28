using System;
using System.Collections.Generic;
using System.Text;

namespace GitTest
{
    public class BankAcount //PascelCase
    {
        private decimal _Balance; //Backing field 
        public int AccountNumber { get; set; }   // (Auto property)
        public string OwnerName { get; set; }
        public decimal Balance // full property
        {
            get { return _Balance; }
            set { _Balance = value; }
        }
    }
}
