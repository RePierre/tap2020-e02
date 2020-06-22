using System;
using System.Collections.Generic;
using System.Text;

namespace GalbinitaSebastian
{
    public class Customer
    {
        public string Name { get; set; }
        public long CustomerIBAN { get; set; }
        public Customer( string name, long ibn)
        {
           
            Name = name;
            CustomerIBAN = ibn;
        }

        public string GetContactInfo() { return "ContactInfo"; }
        public string GetTransactionHistory() { return "History"; }
    }
}
