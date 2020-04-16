using System;
using System.Collections.Generic;
using System.Text;

namespace Evaluare2
{
    public abstract class IsPalindrom
    {
        //interfata de creat

        public decimal CalculTotal(ulong iban, decimal account)
        {
            if (CalculatePalindrom(iban) == "Palindrom")
                return account + 512;
            else
                return account;
        }

        protected abstract string CalculatePalindrom(ulong iban);

        
    }
}
