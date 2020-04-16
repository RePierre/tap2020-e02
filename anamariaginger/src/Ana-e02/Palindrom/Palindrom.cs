using System;

namespace Palindrom
{
   
        public static class Palindrom
        {

            public static bool isPalindrom(long IBAN)
            {


                long n, digit, inv = 0;

                n = IBAN;

                do
                {
                    digit = IBAN % 10;
                    inv = (inv * 10) + digit;
                    IBAN = IBAN / 10;
                } while (IBAN != 0);

                if (n == inv)
                    return true;
                else
                    return false;


            }
        }
    
}
