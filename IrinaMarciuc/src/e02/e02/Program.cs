using System;
namespace e02
{
    //delegate void ProcessIsPalindromeDelegate(Palindrome args)
    class Program
    { 
        static void Main(string[] args)
        {
            string s = "RO54PORL1861388332588433";
           // ProcessIsPalindromeDelegate pipd = Palindrome.IsPalindrome;
            var result = s.IsPalindrome();
           // bool b = p.IsPalindrome(s);
            Console.WriteLine(result);
        }
    }
}
