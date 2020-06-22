
using System;
using System.Collections.Generic;
using System.Text;

namespace e02
    {
       public static class Palindrome
        {
            public static bool IsPalindrome(this string IBAN)
            {
                int i = 0;
                int j = IBAN.Length - 1;
                while (true)
                {
                    if (i > j)
                    {
                        return true;
                    }
                    char a = IBAN[i];
                    char b = IBAN[j];
                    if (char.ToLower(a) != char.ToLower(b))
                    {
                        return false;
                    }
                    i++;
                    j--;
                }
            }
        }
 }

