using System;
using System.Collections.Generic;
using System.Text;

namespace Palindrome
{
    public static class Extensions
    {

        public static bool isPalindrome(this string iban)
        {
            int half_lenght_of_numbers_in_iban = (iban.Length -8)/2;
            
            //lungimea ibanului este numar par (24) in caz contrar nu este iban si se va return false
            if (iban.Length % 2 == 1) throw new System.ArgumentException("Iban is invalid");
            else
            {
                for (int i = 8; i <half_lenght_of_numbers_in_iban; i++)
                {
                    if (iban[i] != iban[2 * half_lenght_of_numbers_in_iban - i - 1]) return false;
                    else return true;
                }
            }
            return true;
        }
    }
}
