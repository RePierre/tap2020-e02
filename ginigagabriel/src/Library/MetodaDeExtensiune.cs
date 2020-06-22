using System;
using System.Collections;

namespace Library
{
    public static class MetodaDeExtensiune
    {
        public static bool IsPalindrom(this String IBAN)
        {
            string copy = IBAN;
            string reversed;
            char[] charArraytoReverse = IBAN.ToCharArray();
            Array.Reverse(charArraytoReverse);
            reversed = new string(charArraytoReverse);
            
            string firstPart = IBAN.Substring(0, (int)(IBAN.Length / 2));
            string secondPart = reversed.Substring(0, (int)(reversed.Length/2));

            if (firstPart == secondPart)
                return true;
            else return false;
        }
    }
}
