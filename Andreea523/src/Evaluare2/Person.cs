using System;
using System.Collections.Generic;
using System.Text;

namespace Evaluare2
{
    class Person: Bank
    {

        public Person(ulong iban, string name)
        {
            this.Iban = iban;
            this.Name = name;

        }
        public Person(ulong iban, string name, decimal account)
        {
            this.Iban = iban;
            this.Name = name;
            this.Account = account;
           
        }
    }
}
