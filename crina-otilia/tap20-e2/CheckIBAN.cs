using System;
using System.Collections.Generic;
using System.Text;

namespace tap20_e2
{
    public class CheckIBAN:IsPalindrom
    {
        public IsPalindrom p;
        public void CheckPalindrome( IBan iban) {
            int number = Int32.Parse(iban.IBAN);
            if (p.Palindrome(number))
                Console.WriteLine("{0} este un palindrom!",iban.IBAN);
            else
                Console.WriteLine("{0} nu este un palindrom!", iban.IBAN);

        }
    }
}
