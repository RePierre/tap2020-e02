using System;
using System.Collections.Generic;
using System.Text;

namespace tapE2
{
    public class IsPalindrom
    {
        public bool Palindrome(int IBAN)
        {
            int temp = IBAN;
            int r=0;
            int sum = 0;
            while (IBAN > 0)
            {
                r = IBAN % 10;
                sum = (sum * 10) + r;
                IBAN = IBAN / 10;
            }
            if (temp == sum)
                return true;
            else
                return false;
        }
    }
}
