using BankAccounts.Core;
using System;


namespace BankAccounts
{
    class Program
    {
        static void Main(string[] args)
        {
            IBAN ibanThatIsPalindrome = new IBAN("RO41RZBR1234567887654321");
            IBAN ibanThatIsNotPalindrome = new IBAN("RO41RZBR1874829486230562");

            Console.WriteLine(ibanThatIsPalindrome.IsPalindrome());
            Console.WriteLine(ibanThatIsNotPalindrome.IsPalindrome());
        }
    }
}
