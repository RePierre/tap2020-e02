using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace BankAccounts.Core
{
    public static class IBANExtension
    {
        public static bool IsPalindrome(this IBAN iban)
        {
            return iban.AccountNumber.SequenceEqual(iban.AccountNumber.Reverse());
        }
    }
}
