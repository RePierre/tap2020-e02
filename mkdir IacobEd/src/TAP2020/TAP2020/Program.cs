using System;
using TAP;

namespace TAP2020
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool status;
            string iban;

            Console.WriteLine("Enter your IBAN : ");
            iban = Console.ReadLine();
            status = TAP.IsPalindrome.getPalindrome(iban);

            if (status)
            {
                Console.WriteLine("It's not a palindrome !");
            }
            else
            {
                Console.WriteLine("It's palindrome !");
            }
            
        }
    }
}
