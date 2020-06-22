using System;
using System.Collections.Generic;
using System.Text;

namespace tapE2
{
    public class CheckIBAN
    {
        public IsPalindrom p;
        public string s;

        public void CheckPalindrome( IBan iban) {
            //int number = Int32.Parse(iban.IBAN);
            if (p.Palindrome(iban.IBAN))
                Console.WriteLine("{0} este un palindrom!",iban.IBAN);
            else
                Console.WriteLine("{0} nu este un palindrom!", iban.IBAN);

        }
    }

    public class Rooter
    {
    }
}
