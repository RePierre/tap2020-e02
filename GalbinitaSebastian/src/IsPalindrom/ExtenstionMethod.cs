using System;
using System.Collections.Generic;
using System.Text;

namespace Uaic.IsPalindrom
{
    public static class ExtenstionMethod
    {
        public static bool IsPalindrom(this string IBAN)
        {
            string reversed;
            char[] charArrayToReverse = IBAN.ToCharArray();
            Array.Reverse(charArrayToReverse);
            reversed = new string(charArrayToReverse);

            string firstPart = IBAN.Substring(0, (int)(IBAN.Length / 2));
            string secondPart = reversed.Substring(0, (int)(reversed.Length / 2));

            if (firstPart == secondPart) return true;
            return false;
        }


    }
}
