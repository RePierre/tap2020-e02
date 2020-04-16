using System;
using System.Collections.Generic;
using System.Text;

namespace Evaluare2.Core.Calculate
{
    public abstract class IsPalindrom : IIsPalindrom
    {
        //interfata de creat

        public decimal CalculTotal(int iban, decimal account)
        {
            if (CalculatePalindrom(iban) == true)
                return account + 512;
            else
                return account;
        }

        protected abstract bool CalculatePalindrom(int iban);


    }
}
