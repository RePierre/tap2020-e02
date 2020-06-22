using System;
using System.Collections.Generic;
using System.Text;
using Evaluare2.Core.Assets.Base;
namespace Evaluare2.Core.Assets
{
    class Person: Bank
    {

        public Person(ulong iban, string name)
        {
            ulong iban1 = iban;
            Iban = iban1;
            this.Name = name;

        }
        public Person(ulong iban, string name, decimal account)
        {
            Iban = iban;
            this.Name = name;
            this.Account = account;
           
        }
    }
}
