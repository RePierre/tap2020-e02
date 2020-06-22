using System;
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
