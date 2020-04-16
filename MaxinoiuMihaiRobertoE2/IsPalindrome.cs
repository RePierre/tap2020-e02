using System;
using System.Collections.Generic;
using System.Text;

namespace MaxinoiuMihaiRobertoE2
{
    public class PalindromeExample
    {
        public int Id;

        public void IsPalindrome(string IBAN) {
            string revs="";
            for (int i = IBAN.Length - 1; i >= 0; i--)  
            {
                revs += IBAN[i].ToString();
            }
            if (revs == IBAN)  
            {
                Console.WriteLine("Your IBAN is palindrome", IBAN, revs);
            }
            else
            {
                Console.WriteLine("Your IBAN is palindrome", IBAN, revs);
            }
            
        }

        PalindromeExample(int Id) {
            this.Id = Id;
        }
    }
}
