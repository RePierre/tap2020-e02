using System;
using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    class IsPalindrome
    {
        static void Main(string[] args)
        {

            ulong number = 0;
            ulong tNumber = 0;
            ulong rem = 0;
            ulong rev = 0;

            Console.Write("Enter IBAN (numbers): ");
            tNumber = number = ulong.Parse(Console.ReadLine());

            while (number > 0)
            {
                rem = number % 10;
                rev = rev * 10 + rem;
                number = number / 10;

            }
            if (rev == tNumber)
                Console.WriteLine("IBAN is palindrome");
            else
                Console.WriteLine("IBAN is NOT palindrome");
        }

    }
}
