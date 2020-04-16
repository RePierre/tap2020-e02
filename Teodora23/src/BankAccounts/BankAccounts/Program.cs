using System;
using BankAccounts.Core;

namespace CheckPromoValidity
{
    class Program
    {
        static void Main(string[] args)
        {
            IBAN ibanThatIsPalindrome = new IBAN();
            ibanThatIsPalindrome.SetIBAN("RO41RZBR1234567887654321");
            IBAN ibanThatIsNotPalindrome = new IBAN();
            ibanThatIsNotPalindrome.SetIBAN("RO41RZBR1764567821546321");

            Console.WriteLine(ibanThatIsPalindrome.IsPalindrome());
            Console.WriteLine(ibanThatIsNotPalindrome.IsPalindrome());
        }
    }
}
