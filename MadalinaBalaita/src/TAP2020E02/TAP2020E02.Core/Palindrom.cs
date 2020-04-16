using System;
using System.Collections.Generic;
using System.Text;

namespace TAP2020E02.Core
{
    public static class Palindrom
    {
        
            public static bool IsPalindrom(long Iban)
            {//methos to see if it is Palindrom or not
            long n,num,digit,rev=0;
            num = Iban;
            n = num;
            do
            {
                digit =num % 10;
                rev = (rev * 10) + digit;
                num = num / 10;
            } while (num != 0);

            if (n == rev)
                return true;
            else  return false;
        }
       
        
    }
}
